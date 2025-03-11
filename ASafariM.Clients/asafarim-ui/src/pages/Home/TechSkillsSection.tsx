const TechSkillsSection = () => {
  return (
    <div className="bg-white dark:bg-gray-800 rounded-xl shadow-lg p-8 mb-10">
      <h2 className="text-3xl font-bold text-teal-600 dark:text-teal-400 mb-6">
        Technical Expertise
      </h2>
      <div className="grid grid-cols-1 md:grid-cols-3 gap-6">
        <div className="bg-gray-50 dark:bg-gray-700 p-6 rounded-lg shadow-md hover:shadow-lg transition duration-300">
          <h3 className="text-xl font-semibold text-teal-600 dark:text-teal-400 mb-3">
            Backend Development
          </h3>
          <p className="text-gray-700 dark:text-gray-300 mb-4">
            Expertise in .NET Core, C#, and RESTful API design with a focus on
            clean architecture and performance.
          </p>
          <div className="flex flex-wrap gap-2">
            <span className="px-3 py-1 bg-teal-100 dark:bg-teal-900 text-teal-800 dark:text-teal-200 rounded-full text-sm">
              .NET Core
            </span>
            <span className="px-3 py-1 bg-teal-100 dark:bg-teal-900 text-teal-800 dark:text-teal-200 rounded-full text-sm">
              C#
            </span>
            <span className="px-3 py-1 bg-teal-100 dark:bg-teal-900 text-teal-800 dark:text-teal-200 rounded-full text-sm">
              MongoDB
            </span>
          </div>
        </div>
        <div className="bg-gray-50 dark:bg-gray-700 p-6 rounded-lg shadow-md hover:shadow-lg transition duration-300">
          <h3 className="text-xl font-semibold text-teal-600 dark:text-teal-400 mb-3">
            Frontend Development
          </h3>
          <p className="text-gray-700 dark:text-gray-300 mb-4">
            Creating responsive and intuitive user interfaces with modern
            JavaScript frameworks and CSS.
          </p>
          <div className="flex flex-wrap gap-2">
            <span className="px-3 py-1 bg-teal-100 dark:bg-teal-900 text-teal-800 dark:text-teal-200 rounded-full text-sm">
              React
            </span>
            <span className="px-3 py-1 bg-teal-100 dark:bg-teal-900 text-teal-800 dark:text-teal-200 rounded-full text-sm">
              TypeScript
            </span>
            <span className="px-3 py-1 bg-teal-100 dark:bg-teal-900 text-teal-800 dark:text-teal-200 rounded-full text-sm">
              TailwindCSS
            </span>
          </div>
        </div>
        <div className="bg-gray-50 dark:bg-gray-700 p-6 rounded-lg shadow-md hover:shadow-lg transition duration-300">
          <h3 className="text-xl font-semibold text-teal-600 dark:text-teal-400 mb-3">
            Data Analysis
          </h3>
          <p className="text-gray-700 dark:text-gray-300 mb-4">
            Transforming data into actionable insights using modern data
            analysis tools and techniques.
          </p>
          <div className="flex flex-wrap gap-2">
            <span className="px-3 py-1 bg-teal-100 dark:bg-teal-900 text-teal-800 dark:text-teal-200 rounded-full text-sm">
              R.Net
            </span>
            <span className="px-3 py-1 bg-teal-100 dark:bg-teal-900 text-teal-800 dark:text-teal-200 rounded-full text-sm">
              Data Visualization
            </span>
            <span className="px-3 py-1 bg-teal-100 dark:bg-teal-900 text-teal-800 dark:text-teal-200 rounded-full text-sm">
              Statistical Analysis
            </span>
          </div>
        </div>
      </div>
    </div>
  );
};

export default TechSkillsSection;
