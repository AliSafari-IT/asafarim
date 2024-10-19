import DisplayMd from "../../components/DisplayMd";
import Wrapper from "../../layout/Wrapper/Wrapper";
// Import Markdown file as raw text
import aboutMeMd from './aboutme.md?raw';

export default function About(): JSX.Element {
  const envVariable = (import.meta as any).env;

  let APP_URL = envVariable.VITE_API_URL || 'https://asafarim.com';
  if (window.location.hostname === 'preview.asafarim.com') {
    APP_URL = envVariable.Preview_URL;
  }

  const headerBlock = (
    <div className="w-full text-center m-0 text-gray-200 p-3 bg-gray-700">
      <h1 className="text-2xl font-bold">About Me 🛠️</h1>
    </div>
  );

  const asideBlock = (
    <div className="w-full text-center m-0 text-gray-200 p-3  bg-gray-700">
      <h1 className="text-xl font-bold">About Me 🛠️</h1> 
      <div>
        <ul className="list-none flex flex-col justify-start items-start ">
          <li className="">
            <a
              href={'/about/akkodis-targeted-resume'}
              target="_blank"
              rel="noopener noreferrer"
              className="text-blue-300 hover:text-teal-600 hover:underline"
            >
              Akkodis Targeted Resume
            </a>
          </li>
           
        </ul>
      </div>
    </div>
  );

  return (
    <Wrapper header={headerBlock} footer={null} className="p-0 m-0  "
      sidebar={asideBlock}>
      <DisplayMd filePath={aboutMeMd} />
    </Wrapper>
  );
};
