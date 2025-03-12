export const ExperienceTimeline = () => {
  return (
    <div className="relative p-8 rounded-3xl bg-gradient-to-br from-[var(--bg-primary)] to-[var(--bg-secondary)] shadow-2xl backdrop-blur-lg">
      <h2 className="text-3xl md:text-4xl font-extrabold mb-12 text-[var(--teams-purple)] relative group">
        <span className="bg-clip-text text-transparent bg-gradient-to-r from-[var(--teams-purple)] to-[var(--teams-blue)]">
          Professional Journey
        </span>
        <div className="absolute bottom-0 left-0 h-1 w-full bg-gradient-to-r from-[var(--teams-purple)] to-[var(--teams-blue)] transform scale-x-0 group-hover:scale-x-100 transition-transform duration-500 origin-left"></div>
      </h2>

      <div className="relative pl-12 space-y-16">
        {/* Timeline Connector */}
        <div className="absolute left-0 top-0 bottom-0 w-1 bg-gradient-to-b from-[var(--teams-purple)] via-[var(--info)] to-[var(--success)] rounded-full shadow-[0_0_15px_-3px_var(--teams-purple)] animate-pulse-slow"></div>

        {/* Experience 1 - Full Stack */}
        <div className="relative group">
          <div className="absolute -left-[3.4rem] top-0 w-12 h-12 bg-gradient-to-br from-[var(--teams-purple)] to-[#3a3c7c] rounded-2xl shadow-2xl flex items-center justify-center border-4 border-[var(--bg-primary)] transform transition-all duration-500 group-hover:-rotate-12 group-hover:scale-110">
            <svg
              xmlns="http://www.w3.org/2000/svg"
              className="w-6 h-6 text-white"
              viewBox="0 0 24 24"
              fill="none"
              stroke="currentColor"
              strokeWidth="2"
            >
              <path d="M13 2L3 14h9l-1 8 10-12h-9l1-8z" />
            </svg>
          </div>

          <div className="bg-gradient-to-br from-[#6264a7]/90 to-[#464775]/90 p-8 rounded-2xl shadow-2xl backdrop-blur-sm transform transition-all duration-500 group-hover:translate-x-6 group-hover:shadow-[0_25px_50px_-12px_rgba(98,100,167,0.3)]">
            <div className="flex flex-col sm:flex-row justify-between items-start gap-4 mb-4">
              <h3 className="text-2xl font-bold text-[var(--text-primary)] leading-tight">
                Full Stack Innovation
                <span className="block text-lg font-medium text-[var(--text-secondary)] mt-1">
                  XiTechniX
                </span>
              </h3>
              <div className="flex items-center gap-2 bg-[var(--bg-secondary)]/10 px-4 py-2 rounded-full">
                <span className="text-sm font-semibold text-[var(--text-primary)]">
                  2019-2022
                </span>
                <div className="w-2 h-2 bg-[var(--teams-purple)] rounded-full animate-pulse"></div>
              </div>
            </div>
            <ul className="space-y-3 text-[var(--text-primary)]/80">
              <li className="flex items-center gap-2 before:content-['▹'] before:text-[var(--teams-blue)]">
                Developed laboratory automation systems using C#, React TypeScript, and .NET Core
              </li>
              <li className="flex items-center gap-2 before:content-['▹'] before:text-[var(--teams-blue)]">
                Built responsive UIs with React/TypeScript and high-performance backends with C#
              </li>
              <li className="flex items-center gap-2 before:content-['▹'] before:text-[var(--teams-blue)]">
                Integrated SQL Server and MongoDB for real-time experimental data management
              </li>
              <li className="flex items-center gap-2 before:content-['▹'] before:text-[var(--teams-blue)]">
                Collaborated with scientists and engineers to deliver custom IoT-integrated solutions
              </li>
            </ul>
          </div>
        </div>

        {/* Experience 2 - .NET Development */}
        <div className="relative group">
          <div className="absolute -left-[3.4rem] top-0 w-12 h-12 bg-gradient-to-br from-[var(--info)] to-[#2d4a9e] rounded-2xl shadow-2xl flex items-center justify-center border-4 border-[var(--bg-primary)] transform transition-all duration-500 group-hover:-rotate-12 group-hover:scale-110">
            <svg
              xmlns="http://www.w3.org/2000/svg"
              className="w-6 h-6 text-white"
              viewBox="0 0 24 24"
              fill="none"
              stroke="currentColor"
              strokeWidth="2"
            >
              <path d="M12 2l9 4v10l-9 4-9-4V6l9-4zM12 6v4m-5 4l5 2 5-2M7 10l5 2 5-2M7 14l5 2 5-2" />
            </svg>
          </div>

          <div className="bg-gradient-to-br from-[var(--info)]/90 to-[var(--info-dark)]/90 p-8 rounded-2xl shadow-2xl backdrop-blur-sm transform transition-all duration-500 group-hover:translate-x-6 group-hover:shadow-[0_25px_50px_-12px_rgba(79,107,237,0.3)]">
            <div className="flex flex-col sm:flex-row justify-between items-start gap-4 mb-4">
              <h3 className="text-2xl font-bold text-[var(--text-primary)] leading-tight">
                .NET Excellence
                <span className="block text-lg font-medium text-[var(--text-secondary)] mt-1">
                  IRC Engineering
                </span>
              </h3>
              <div className="flex items-center gap-2 bg-[var(--bg-secondary)]/10 px-4 py-2 rounded-full">
                <span className="text-sm font-semibold text-[var(--text-primary)]">
                  2018-2019
                </span>
                <div className="w-2 h-2 bg-[var(--info)] rounded-full animate-pulse"></div>
              </div>
            </div>
            <ul className="space-y-3 text-[var(--text-primary)]/80">
              <li className="flex items-center gap-2 before:content-['▹'] before:text-[var(--info-light)]">
                Engineered predictive analytics modules with interactive time
                series visualizations using C# and WPF
              </li>
              <li className="flex items-center gap-2 before:content-['▹'] before:text-[var(--info-light)]">
                Integrated R.NET statistical models in WPF Windows application for time series analysis
              </li>
            </ul>
          </div>
        </div>

        {/* Experience 3 - Scientific Development */}
        <div className="relative group">
          <div className="absolute -left-[3.4rem] top-0 w-12 h-12 bg-gradient-to-br from-[var(--success)] to-[#5a8cf0] rounded-2xl shadow-2xl flex items-center justify-center border-4 border-[var(--bg-primary)] transform transition-all duration-500 group-hover:-rotate-12 group-hover:scale-110">
            <svg
              xmlns="http://www.w3.org/2000/svg"
              className="w-6 h-6 text-white"
              viewBox="0 0 24 24"
              fill="none"
              stroke="currentColor"
              strokeWidth="2"
            >
              <path d="M19 14l-7 7m0 0l-7-7m7 7V3" />
            </svg>
          </div>

          <div className="bg-gradient-to-br from-[var(--success)]/90 to-[var(--success-dark)]/90 p-8 rounded-2xl shadow-2xl backdrop-blur-sm transform transition-all duration-500 group-hover:translate-x-6 group-hover:shadow-[0_25px_50px_-12px_rgba(146,195,83,0.3)]">
            <div className="flex flex-col sm:flex-row justify-between items-start gap-4 mb-4">
              <h3 className="text-2xl font-bold text-[var(--text-primary)] leading-tight">
                Scientific Innovation
                <span className="block text-lg font-medium text-[var(--text-secondary)] mt-1">
                  Vlaamse Milieumaatschappij (VMM) & VUB University in Belgium
                </span>
              </h3>
              <div className="flex items-center gap-2 bg-[var(--bg-secondary)]/10 px-4 py-2 rounded-full">
                <span className="text-sm font-semibold text-[var(--text-primary)]">
                  2017-2018
                </span>
                <div className="w-2 h-2 bg-[var(--success)] rounded-full animate-pulse"></div>
              </div>
            </div>
            <ul className="space-y-3 text-[var(--text-primary)]/80">
              <li className="flex items-center gap-2 before:content-['▹'] before:text-[var(--success-light)]">
                Enhanced the WetSpa hydrologic model for 5 pilot watersheds at
                VMM, coded in FORTRAN, for advanced river flow simulations and
                leveraged scientific software programming to improve model
                accuracy and efficiency.
              </li>
              <li className="flex items-center gap-2 before:content-['▹'] before:text-[var(--success-light)]">
                Developed, applied, and calibrated hydrological models for flood
                risk assessments and resource management at VUB.
              </li>
              <li className="flex items-center gap-2 before:content-['▹'] before:text-[var(--success-light)]">
                Performed big data analytics and statistical modeling for
                environmental projects at VUB.
              </li>
              <li className="flex items-center gap-2 before:content-['▹'] before:text-[var(--success-light)]">
                Used numerical hydrological modeling for disaster mitigation and
                water quality prediction at VUB.
              </li>
            </ul>
          </div>
        </div>
      </div>
    </div>
  );
};

export default ExperienceTimeline;
