export const TechStackSection = () => {
  return (
    <div className="relative py-8 px-6 rounded-xl bg-gradient-to-b from-[var(--bg-primary)] to-[var(--bg-secondary)] shadow-lg">
      <h2 className="text-3xl md:text-4xl font-extrabold mb-12 text-[var(--teams-purple)] relative group">
        <span className="bg-clip-text text-transparent bg-gradient-to-r from-[var(--teams-purple)] to-[var(--teams-blue)]">
          Tech Stack
        </span>
        <div className="absolute bottom-0 left-0 h-1 w-full bg-gradient-to-r from-[var(--teams-purple)] to-[var(--teams-blue)] transform scale-x-0 group-hover:scale-x-100 transition-transform duration-500 origin-left"></div>
      </h2>
      <div className="grid grid-cols-1 md:grid-cols-3 gap-6">
        {/* Frontend Card */}
        <div className="tech-card relative overflow-hidden rounded-xl shadow-md transition-all duration-300 hover:shadow-xl hover:transform hover:scale-[1.02] group">
          <div className="absolute inset-0 bg-gradient-to-br from-[#6264a7] to-[#464775] opacity-90"></div>
          <div className="relative z-10 p-5">
            <div className="flex items-start mb-4">
              <div className="bg-white bg-opacity-20 p-2 rounded-lg mr-4 transition-all duration-300 group-hover:bg-opacity-30 group-hover:shadow-[0_0_8px_rgba(255,255,255,0.3)]">
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  viewBox="0 0 24 24"
                  fill="none"
                  stroke="currentColor"
                  className="w-7 h-7 text-white"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    strokeWidth="2"
                    d="M4 6h16M4 12h16m-7 6h7"
                  ></path>
                </svg>
              </div>
              <h3 className="text-xl font-bold text-white mb-1">Frontend</h3>
            </div>

            <ul className="space-y-2">
              {["React", "TypeScript", "Fluent UI", "TailwindCSS"].map(
                (tech, i) => (
                  <li
                    key={i}
                    className="flex items-center text-white group-hover:translate-x-1 transition-transform duration-300"
                  >
                    <span className="inline-block w-1.5 h-1.5 bg-white rounded-full mr-2"></span>
                    <span>{tech}</span>
                  </li>
                )
              )}
            </ul>
          </div>
        </div>

        {/* Backend Card */}
        <div className="tech-card relative overflow-hidden rounded-xl shadow-md transition-all duration-300 hover:shadow-xl hover:transform hover:scale-[1.02] group">
          <div className="absolute inset-0 bg-gradient-to-br from-[#4f6bed] to-[#3e5baa] opacity-90"></div>
          <div className="relative z-10 p-5">
            <div className="flex items-start mb-4">
              <div className="bg-white bg-opacity-20 p-2 rounded-lg mr-4 transition-all duration-300 group-hover:bg-opacity-30 group-hover:shadow-[0_0_8px_rgba(255,255,255,0.3)]">
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  viewBox="0 0 24 24"
                  fill="none"
                  stroke="currentColor"
                  className="w-7 h-7 text-white"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    strokeWidth="2"
                    d="M5 12h14M5 12a2 2 0 01-2-2V6a2 2 0 012-2h14a2 2 0 012 2v4a2 2 0 01-2 2M5 12a2 2 0 00-2 2v4a2 2 0 002 2h14a2 2 0 002-2v-4a2 2 0 00-2-2"
                  ></path>
                </svg>
              </div>
              <h3 className="text-xl font-bold text-white mb-1">Backend</h3>
            </div>

            <ul className="space-y-2">
              {["ASP.NET Core 9", "C#", "Entity Framework"].map((tech, i) => (
                <li
                  key={i}
                  className="flex items-center text-white group-hover:translate-x-1 transition-transform duration-300"
                >
                  <span className="inline-block w-1.5 h-1.5 bg-white rounded-full mr-2"></span>
                  <span>{tech}</span>
                </li>
              ))}
            </ul>
          </div>
        </div>

        {/* Database Card */}
        <div className="tech-card relative overflow-hidden rounded-xl shadow-md transition-all duration-300 hover:shadow-xl hover:transform hover:scale-[1.02] group">
          <div className="absolute inset-0 bg-gradient-to-br from-[#92c353] to-[#6c9ef8] opacity-90"></div>
          <div className="relative z-10 p-5">
            <div className="flex items-start mb-4">
              <div className="bg-white bg-opacity-20 p-2 rounded-lg mr-4 transition-all duration-300 group-hover:bg-opacity-30 group-hover:shadow-[0_0_8px_rgba(255,255,255,0.3)]">
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  viewBox="0 0 24 24"
                  fill="none"
                  stroke="currentColor"
                  className="w-7 h-7 text-white"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    strokeWidth="2"
                    d="M4 7v10c0 2 1 3 3 3h10c2 0 3-1 3-3V7c0-2-1-3-3-3H7c-2 0-3 1-3 3z"
                  ></path>
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    strokeWidth="2"
                    d="M9 17v-8"
                  ></path>
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    strokeWidth="2"
                    d="M12 17v-10"
                  ></path>
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    strokeWidth="2"
                    d="M15 17v-5"
                  ></path>
                </svg>
              </div>
              <h3 className="text-xl font-bold text-white mb-1">
                Database & Analytics
              </h3>
            </div>

            <ul className="space-y-2">
              {["MySQL", "SQL Server", "D3.js", "Power BI"].map((tech, i) => (
                <li
                  key={i}
                  className="flex items-center text-white group-hover:translate-x-1 transition-transform duration-300"
                >
                  <span className="inline-block w-1.5 h-1.5 bg-white rounded-full mr-2"></span>
                  <span>{tech}</span>
                </li>
              ))}
            </ul>
          </div>
        </div>
      </div>
    </div>
  );
};

export default TechStackSection;
