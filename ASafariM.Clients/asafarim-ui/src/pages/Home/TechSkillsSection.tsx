import React, { useState } from "react";

const TechSkillsSection = () => {
  const [hoveredCard, setHoveredCard] = useState<number | null>(null);

  const skills = [
    {
      id: 1,
      title: "Backend Development",
      description: "Expertise in .NET Core, C#, and RESTful API design with a focus on clean architecture and performance.",
      icon: "🚀",
      gradient: "from-blue-500 to-purple-600",
      tags: [".NET Core", "C#", "MongoDB"],
      borderColor: "border-blue-500/30"
    },
    {
      id: 2,
      title: "Frontend Development", 
      description: "Creating responsive and intuitive user interfaces with modern JavaScript frameworks and CSS.",
      icon: "⚛️",
      gradient: "from-teal-500 to-green-600",
      tags: ["React", "TypeScript", "TailwindCSS"],
      borderColor: "border-teal-500/30"
    },
    {
      id: 3,
      title: "Data Analysis",
      description: "Transforming data into actionable insights using modern data analysis tools and techniques.",
      icon: "📊",
      gradient: "from-purple-500 to-pink-600",
      tags: ["R.Net", "Data Visualization", "Statistical Analysis"],
      borderColor: "border-purple-500/30"
    }
  ];

  return (
    <div className="relative py-16 px-4">
      {/* Background decoration */}
      <div className="absolute inset-0 bg-gradient-to-r from-blue-50/50 via-teal-50/50 to-purple-50/50 dark:from-gray-800/50 dark:via-gray-900/50 dark:to-gray-800/50 rounded-3xl"></div>
      
      <div className="relative max-w-7xl mx-auto">        {/* Section Header */}
        <div className="text-center mb-16">
          <h2 className="text-4xl lg:text-5xl font-bold text-teal-600 dark:text-teal-400 mb-4">
            Technical Expertise
          </h2>
          <p className="text-xl text-gray-600 dark:text-gray-400 max-w-3xl mx-auto">
            Crafting exceptional digital experiences through cutting-edge technologies and best practices
          </p>
          <div className="w-24 h-1 bg-gradient-to-r from-teal-500 to-blue-500 rounded-full mx-auto mt-6"></div>
        </div>

        {/* Skills Grid */}
        <div className="grid md:grid-cols-3 gap-8">
          {skills.map((skill, index) => (
            <div
              key={skill.id}
              className={`group relative bg-white/80 dark:bg-gray-800/80 backdrop-blur-sm rounded-2xl shadow-xl border ${skill.borderColor} p-8 hover:shadow-2xl transition-all duration-500 transform hover:-translate-y-2 ${
                hoveredCard === skill.id ? 'scale-105' : ''
              }`}
              onMouseEnter={() => setHoveredCard(skill.id)}
              onMouseLeave={() => setHoveredCard(null)}
              style={{
                animationDelay: `${index * 200}ms`
              }}
            >
              {/* Gradient background on hover */}
              <div className={`absolute inset-0 bg-gradient-to-br ${skill.gradient} opacity-0 group-hover:opacity-10 rounded-2xl transition-opacity duration-500`}></div>
              
              {/* Icon */}
              <div className="relative mb-6">
                <div className="w-16 h-16 bg-gradient-to-br from-gray-100 to-gray-200 dark:from-gray-700 dark:to-gray-600 rounded-xl flex items-center justify-center text-3xl group-hover:scale-110 transition-transform duration-300 shadow-lg">
                  {skill.icon}
                </div>
                {/* Animated border */}
                <div className={`absolute inset-0 bg-gradient-to-r ${skill.gradient} rounded-xl opacity-0 group-hover:opacity-100 transition-opacity duration-300 -z-10 blur-xl`}></div>
              </div>
                {/* Content */}
              <div className="relative">
                <h3 className="text-2xl font-bold text-gray-800 dark:text-gray-200 mb-4 group-hover:text-teal-600 dark:group-hover:text-teal-400 transition-all duration-300">
                  {skill.title}
                </h3>
                
                <p className="text-gray-600 dark:text-gray-400 mb-6 leading-relaxed">
                  {skill.description}
                </p>
                
                {/* Tags */}
                <div className="flex flex-wrap gap-2">
                  {skill.tags.map((tag, tagIndex) => (
                    <span
                      key={tagIndex}
                      className={`px-3 py-2 bg-gradient-to-r ${skill.gradient} text-white rounded-lg text-sm font-medium shadow-md transform group-hover:scale-105 transition-all duration-300 opacity-90 group-hover:opacity-100`}
                      style={{
                        animationDelay: `${(index * 200) + (tagIndex * 100)}ms`
                      }}
                    >
                      {tag}
                    </span>
                  ))}
                </div>
              </div>
              
              {/* Hover indicator */}
              <div className="absolute top-4 right-4 opacity-0 group-hover:opacity-100 transition-opacity duration-300">
                <div className="w-3 h-3 bg-gradient-to-r from-teal-400 to-blue-500 rounded-full animate-pulse"></div>
              </div>
            </div>
          ))}
        </div>

        {/* Bottom CTA */}
        <div className="text-center mt-16">
          <div className="inline-flex items-center gap-2 px-6 py-3 bg-gradient-to-r from-teal-500 to-blue-600 text-white rounded-full shadow-lg hover:shadow-xl transform hover:scale-105 transition-all duration-300 cursor-pointer group">
            <span className="font-semibold">Explore My Work</span>
            <svg className="w-5 h-5 group-hover:translate-x-1 transition-transform" fill="none" stroke="currentColor" viewBox="0 0 24 24">
              <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M17 8l4 4m0 0l-4 4m4-4H3" />
            </svg>
          </div>
        </div>
      </div>
    </div>
  );
};

export default TechSkillsSection;
