import DisplayMd from "../../components/MarkdownPage/DisplayMd";
import additionalInfoMd from "./additional-info.md?raw";

export default function AdditionalInfo(): JSX.Element {
  return (
    <div className="prose dark:prose-invert max-w-none">
      <DisplayMd markdownContent={additionalInfoMd} id="additional-info" />
    </div>
  );
}
