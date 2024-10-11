import Wrapper from "../layout/Wrapper/Wrapper";

const About = () => {

  const headerBlock = (
    <div className="w-full text-center mx-auto m-0 text-gray-200 p-8 bg-gray-700">
      <h1 className="text-3xl font-bold">About Me!</h1>
    </div>
  );
    return (
      <Wrapper header={headerBlock}>
        <h1 className="text-3xl font-bold">About Page</h1>
        <p>This is the About page.</p>
      </Wrapper>
    );
  };
  
  export default About;
  