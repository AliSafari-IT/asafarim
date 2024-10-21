import DisplayMd from "../../../components/DisplayMd";
import Wrapper from "../../../layout/Wrapper/Wrapper";
// Import Markdown file as raw text
import Akkodis from './Akkodis.md?raw';

export default function AkkodisTargetedResume (): JSX.Element {
  const headerBlock = (
    <div className="w-full text-center mx-auto m-0 text-gray-200 p-0 bg-gray-700">
      <h1 className="text-3xl font-bold py-3">About Me 🛠️</h1>
    </div>
  );

  return (
    <Wrapper header={headerBlock} footer={null} className="p-0 m-0  ">
      <DisplayMd markdownContent={Akkodis} />
    </Wrapper>
  );
};
