// apps\dashboard-client\src\components\Containers\Card.tsx
import {
  makeStyles,
  Body1,
  Caption1,
  Button,
} from "@fluentui/react-components";
import { ArrowReplyRegular, ShareRegular } from "@fluentui/react-icons";
import {
  Card,
  CardFooter,
  CardHeader,
  CardPreview,
} from "@fluentui/react-components";

const resolveAsset = (asset: string) => {
  const ASSET_URL =
    "https://raw.githubusercontent.com/microsoft/fluentui/master/packages/react-components/react-card/stories/src/assets/";

  return `${ASSET_URL}${asset}`;
};

const useStyles = makeStyles({
  card: {
    margin: "auto",
    width: "375px",
    maxWidth: "380px",
    minWidth: "375px",
    boxShadow: "0 1px 3px rgba(0,0,0,0.12), 0 1px 2px rgba(190,0,60,0.24)",
    transition: "all 0.3s cubic-bezier(.25,.8,.25,1)",
    "&:hover": {
      boxShadow: "0 14px 28px rgba(0,0,0,0.25), 0 10px 10px rgba(0,0,0,0.22)",
    },
    "&:focus": {
      outline: "none",
    }
  },
});
interface DashCardProps {
  title?: string;
  description?: string;
  imgPath?: string;
  imgAlt?: string;
  content?: string;
}
export const DashCard: React.FC<DashCardProps> = ({ title,description,imgPath='',imgAlt='Image', content }) => {
  const styles = useStyles();

  return (
    <Card className={styles.card}>
      <CardHeader
        image={
          <img
            src={resolveAsset("avatar_elvia.svg")}
            alt="Elvia Atkins avatar picture"
          />
        }
        header={
          <Body1>
            <strong>{title}</strong>
          </Body1>
        }
        description={<Caption1>{description}</Caption1>}
      />

      <CardPreview
        logo={
          <img src={resolveAsset(imgPath)} alt={imgAlt} />
        }
      >
        <Body1>{content}</Body1>        
      </CardPreview>

      <CardFooter>
        <Button icon={<ArrowReplyRegular fontSize={16} />} onClick={() => {alert("Reply")}}>Reply</Button>
        <Button icon={<ShareRegular fontSize={16} />} onClick={() => { alert("Share") }}>Share</Button>
      </CardFooter>
    </Card>
  );
};