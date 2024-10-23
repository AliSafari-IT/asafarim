import { useParams, useNavigate } from 'react-router-dom';
import { Button, Text } from '@fluentui/react-components';
import dashboardServices from '../../../api/dashboardServices';
import Wrapper from '../../../layout/Wrapper/Wrapper';

const DelCard = () => {
  const { model, id } = useParams<{ model: string; id: string }>();
  const navigate = useNavigate();

  const handleDelete = async () => {
    try {
      switch (model) {
        case 'tags':
          await dashboardServices.deleteTag(id!);
          break;
        case 'topics':
          await dashboardServices.deleteTopic(id!);
          break;
        case 'blogposts':
          await dashboardServices.deleteBlogPost(id!);
          break;
        default:
          alert('Unknown model type.');
          return;
      }
      alert(`${model} deleted successfully`);
      navigate(-1); // Go back after deletion
    } catch (error) {
      console.error(`Error deleting ${model}:`, error);
      alert(`Failed to delete ${model}`);
    }
  };

  return (
    <Wrapper header={<h1>Delete {model}</h1>}>
      <Text>Are you sure you want to delete this {model}?</Text>
      <Button onClick={handleDelete} appearance='subtle' style={{ margin: '10px', backgroundColor: 'red', color: 'white' }} >Yes, Delete</Button>
      <Button onClick={() => navigate(-1)} appearance='subtle' style={{ margin: '10px', backgroundColor: 'lightgreen', color: 'black' }}>Cancel</Button>
    </Wrapper>
  );
};

export default DelCard;
