import { Link } from "react-router-dom";
import myPic from "./ali_profile.jpg";

const HeroSection = () => {
  return (
    <div className="bg-gradient-to-r from-teal-500 to-blue-500 dark:from-teal-700 dark:to-blue-800 text-white py-20 px-6 rounded-xl shadow-xl mb-10">
      <div className="container mx-auto max-w-6xl">
        <div className="flex flex-col md:flex-row items-center justify-between">
          <div className="md:w-2/3 mb-10 md:mb-0">
            <h1 className="text-4xl md:text-5xl lg:text-6xl font-bold mb-4 leading-tight">
              Ali Safari
              <span className="block text-2xl md:text-3xl font-medium mt-2 text-teal-100">
                Full Stack Developer | .NET & React Expert | Data Analyst
              </span>
            </h1>
            <p className="text-xl md:text-2xl mb-8 text-teal-50 max-w-2xl">
              Passionate about building robust applications with .NetCore,
              React, and MongoDB, continuously expanding my technical expertise.
            </p>
            <div className="flex flex-wrap gap-4">
              <Link
                to="https://pbk.asafarim.com"
                className="px-8 py-3 bg-white text-teal-700 font-semibold rounded-lg shadow-md hover:bg-teal-50 transition duration-300 text-lg"
                target="_blank"
              >
                View Portfolio
              </Link>
              <Link
                to="/contact"
                className="px-8 py-3 bg-transparent border-2 border-white text-white font-semibold rounded-lg hover:bg-white hover:text-teal-700 transition duration-300 text-lg"
              >
                Hire Me
              </Link>
            </div>
          </div>
          <div className="md:w-1/3 flex justify-center">
            <div className="w-64 h-64 bg-white bg-opacity-20 rounded-full p-2 backdrop-blur-sm">
              <div className="w-full h-full bg-gradient-to-br from-teal-400 to-blue-600 rounded-full flex items-center justify-center">
                <span className="text-6xl">
                    <img src={myPic} alt="MyPic" className="w-full h-full rounded-full" />
                </span>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default HeroSection;
