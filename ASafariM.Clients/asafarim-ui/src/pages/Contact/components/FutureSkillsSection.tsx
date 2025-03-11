const FutureSkillsSection = () => {
    return (
      <div className="bg-gradient-to-r from-teal-500 to-blue-500 dark:from-teal-600 dark:to-blue-600 rounded-xl shadow-lg p-8 text-white">
        <h2 className="text-2xl font-bold mb-4">Skills I'm Developing</h2>
        <p className="mb-4">I'm also interested in the following skills:</p>
  
        <ul className="space-y-4">
          {/* Data Engineering & Business Intelligence */}
          <li className="flex items-center">
            <span className="text-lg mr-3">📊</span>
            <div>
              <p className="font-bold">Data Engineering & Business Intelligence</p>
              <p className="text-teal-100 text-sm">
                Creating **Power BI dashboards, SQL-based analytics, and interactive data visualizations** for business insights.
              </p>
            </div>
          </li>
  
          {/* Cloud & DevOps Engineering */}
          <li className="flex items-center">
            <span className="text-lg mr-3">☁</span>
            <div>
              <p className="font-bold">Cloud & DevOps Engineering</p>
              <p className="text-teal-100 text-sm">
                Managing **CI/CD pipelines, Dockerized deployments, and cloud infrastructure** to optimize web applications.
              </p>
            </div>
          </li>
  
          {/* AI & Machine Learning Integration */}
          <li className="flex items-center">
            <span className="text-lg mr-3">🤖</span>
            <div>
              <p className="font-bold">AI & Machine Learning Integration</p>
              <p className="text-teal-100 text-sm">
                Implementing **AI-powered automation, NLP chatbots, and predictive analytics** for smarter applications.
              </p>
            </div>
          </li>
  
          {/* Secure API & Cybersecurity */}
          <li className="flex items-center">
            <span className="text-lg mr-3">🛡</span>
            <div>
              <p className="font-bold">Secure API & Cybersecurity</p>
              <p className="text-teal-100 text-sm">
                Securing **.NET APIs with JWT, OAuth, and OWASP best practices**, ensuring data integrity and protection.
              </p>
            </div>
          </li>
        </ul>
  
        <div className="mt-6">
          <p className="text-teal-100">
            I'm actively improving my skills in these areas and look forward to opportunities to apply them.
          </p>
        </div>
      </div>
    );
  };
  
  export default FutureSkillsSection;  