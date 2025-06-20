import { Link } from "react-router-dom";
import myPic from "./ali_profile.jpg";
import React, { useState, useEffect } from "react";
import "./hero-animations.css";

const HeroSection = () => {
  const [mousePosition, setMousePosition] = useState({ x: 0, y: 0 });
  const [showAboutModal, setShowAboutModal] = useState(false);
  const [activeTooltip, setActiveTooltip] = useState<string | null>(null);
  const [showSkillModal, setShowSkillModal] = useState<string | null>(null);

  useEffect(() => {
    const handleMouseMove = (e: MouseEvent) => {
      setMousePosition({ x: e.clientX, y: e.clientY });
    };

    window.addEventListener('mousemove', handleMouseMove);
    return () => window.removeEventListener('mousemove', handleMouseMove);
  }, []);

  const techSkills = {
    react: {
      name: "React",
      icon: "⚛️",
      experience: "4+ years",
      description: "Expert in building modern, responsive web applications with React, hooks, and state management.",
      projects: ["ASafariM UI", "Portfolio Website", "E-commerce Platform"],
      certifications: ["React Developer Certification"]
    },
    dotnet: {
      name: ".NET Core",
      icon: ".NET",
      experience: "5+ years",
      description: "Proficient in building scalable backend APIs, microservices, and enterprise applications.",
      projects: ["ASafariM API", "Enterprise CRM", "Microservices Architecture"],
      certifications: ["Microsoft Certified: .NET Developer"]
    },
    database: {
      name: "Database Technologies",
      icon: "DB",
      experience: "6+ years",
      description: "Experienced with MongoDB, MySQL, PostgreSQL, and database design optimization.",
      projects: ["Data Analytics Platform", "User Management System", "E-commerce Database"],
      certifications: ["MongoDB Certified Developer"]
    }
  };

  const handleProfileClick = () => {
    setShowAboutModal(true);
  };

  const handleTechIconClick = (skillKey: string) => {
    setShowSkillModal(skillKey);
  };

  const handleSkillNavigation = (skillName: string) => {
    // Navigate to portfolio filtered by this technology
    window.open(`https://pbk.asafarim.com?filter=${skillName.toLowerCase()}`, '_blank');
  };  return (
    <div className="relative h-[85vh] flex items-center justify-center">
      {/* Animated background */}
      <div className="absolute inset-0 bg-gradient-to-br from-teal-600 via-blue-700 to-purple-800">
        <div 
          className="absolute inset-0 opacity-30"
          style={{
            background: `radial-gradient(600px at ${mousePosition.x}px ${mousePosition.y}px, rgba(29, 78, 216, 0.15), transparent 80%)`
          }}
        />
        
        {/* Floating geometric shapes */}
        <div className="absolute top-20 left-20 w-20 h-20 bg-white/10 rounded-full animate-float"></div>
        <div className="absolute top-40 right-32 w-16 h-16 bg-teal-400/20 rotate-45 animate-float-delay-1"></div>
        <div className="absolute bottom-32 left-1/4 w-12 h-12 bg-blue-400/20 rounded-full animate-float-delay-2"></div>
        <div className="absolute bottom-20 right-20 w-24 h-24 bg-purple-400/20 transform rotate-12 animate-float-delay-3"></div>
      </div>

      <div className="relative z-10 container mx-auto max-w-7xl px-6 py-12">
        <div className="flex flex-col lg:flex-row items-center justify-between gap-12">
          
          {/* Content */}
          <div className="lg:w-3/5 text-center lg:text-left">
            <div className="mb-8">
              <h1 className="text-5xl lg:text-7xl font-bold text-white mb-6 leading-tight">
                <span className="inline-block animate-slide-in-left">Ali</span>
                <span className="inline-block ml-4 animate-slide-in-right text-transparent bg-clip-text bg-gradient-to-r from-teal-300 to-blue-300">
                  Safari
                </span>
              </h1>
              
              <div className="text-2xl lg:text-3xl font-light text-teal-100 mb-4 animate-fade-in-up">
                <span className="block">Full Stack Developer</span>
                <span className="text-lg lg:text-xl text-teal-200 mt-2 block">
                  .NET & React Expert | Data Analyst
                </span>
              </div>
            </div>

            <p className="text-xl lg:text-2xl text-teal-50 mb-10 max-w-2xl leading-relaxed animate-fade-in-up">
              Passionate about building robust applications with{" "}
              <span className="font-semibold text-white">.NetCore</span>,{" "}
              <span className="font-semibold text-white">React</span>, and{" "}
              <span className="font-semibold text-white">MongoDB</span>, 
              continuously expanding my technical expertise.
            </p>
            
            {/* CTA Buttons */}
            <div className="flex flex-col sm:flex-row gap-6 justify-center lg:justify-start animate-fade-in-up">              <Link
                to="https://pbk.asafarim.com"
                className="group px-8 py-4 bg-white text-teal-700 font-semibold rounded-xl shadow-xl hover:shadow-2xl transform hover:-translate-y-1 transition-all duration-300 text-lg flex items-center justify-center gap-2"
                target="_blank"
              >
                <span>View Portfolio</span>
                <svg className="w-5 h-5 group-hover:translate-x-1 transition-transform" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                  <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M17 8l4 4m0 0l-4 4m4-4H3" />
                </svg>
              </Link>
              
              <Link
                to="/contact"
                className="group px-8 py-4 bg-transparent border-2 border-white text-white font-semibold rounded-xl hover:bg-white hover:text-teal-700 transform hover:-translate-y-1 transition-all duration-300 text-lg flex items-center justify-center gap-2"
              >
                <span>Hire Me</span>
                <svg className="w-5 h-5 group-hover:scale-110 transition-transform" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                  <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M8 12h.01M12 12h.01M16 12h.01M21 12c0 4.418-4.03 8-9 8a9.863 9.863 0 01-4.255-.949L3 20l1.395-3.72C3.512 15.042 3 13.574 3 12c0-4.418 4.03-8 9-8s9 3.582 9 8z" />
                </svg>
              </Link>
            </div>
          </div>
            {/* Profile Image */}
          <div className="lg:w-2/5 flex justify-center">
            <div className="relative group cursor-pointer" onClick={handleProfileClick}>
              {/* Outer glow ring */}
              <div className="absolute -inset-4 bg-gradient-to-r from-teal-400 via-blue-500 to-purple-600 rounded-full opacity-75 group-hover:opacity-100 animate-pulse group-hover:animate-spin-slow transition-all duration-300"></div>
              
              {/* Main image container */}
              <div className="relative w-80 h-80 lg:w-96 lg:h-96">
                <div className="w-full h-full bg-gradient-to-br from-white/20 to-white/10 rounded-full p-3 backdrop-blur-sm border border-white/30">
                  <div className="w-full h-full bg-gradient-to-br from-teal-400 to-blue-600 rounded-full flex items-center justify-center overflow-hidden group-hover:scale-105 transition-transform duration-300">
                    <img 
                      src={myPic} 
                      alt="Ali Safari - Full Stack Developer" 
                      className="w-full h-full object-cover rounded-full filter group-hover:brightness-110 transition-all duration-300" 
                      title="Click to learn more about me"
                    />
                  </div>
                </div>
                
                {/* Floating tech icons */}
                <div 
                  className="absolute -top-4 -right-4 w-12 h-12 bg-white rounded-full shadow-lg flex items-center justify-center animate-bounce-slow cursor-pointer hover:scale-110 transition-transform duration-300 group/react"
                  onClick={(e) => {
                    e.stopPropagation();
                    handleTechIconClick('react');
                  }}
                  onMouseEnter={() => setActiveTooltip('react')}
                  onMouseLeave={() => setActiveTooltip(null)}
                  title="React expertise - Click for details"
                >
                  <span className="text-2xl">⚛️</span>
                  {activeTooltip === 'react' && (
                    <div className="absolute -top-16 left-1/2 transform -translate-x-1/2 bg-black text-white px-3 py-2 rounded-lg text-sm whitespace-nowrap z-50">
                      React Expert (4+ years)
                      <div className="absolute top-full left-1/2 transform -translate-x-1/2 border-4 border-transparent border-t-black"></div>
                    </div>
                  )}
                </div>
                
                <div 
                  className="absolute -bottom-2 -left-4 w-10 h-10 bg-blue-500 rounded-full shadow-lg flex items-center justify-center animate-bounce-slow-delay cursor-pointer hover:scale-110 transition-transform duration-300 group/dotnet"
                  onClick={(e) => {
                    e.stopPropagation();
                    handleTechIconClick('dotnet');
                  }}
                  onMouseEnter={() => setActiveTooltip('dotnet')}
                  onMouseLeave={() => setActiveTooltip(null)}
                  title=".NET Core expertise - Click for details"
                >
                  <span className="text-white font-bold text-sm">.NET</span>
                  {activeTooltip === 'dotnet' && (
                    <div className="absolute -top-16 left-1/2 transform -translate-x-1/2 bg-black text-white px-3 py-2 rounded-lg text-sm whitespace-nowrap z-50">
                      .NET Expert (5+ years)
                      <div className="absolute top-full left-1/2 transform -translate-x-1/2 border-4 border-transparent border-t-black"></div>
                    </div>
                  )}
                </div>
                
                <div 
                  className="absolute top-1/2 -right-6 w-8 h-8 bg-green-500 rounded-full shadow-lg flex items-center justify-center animate-pulse cursor-pointer hover:scale-110 transition-transform duration-300 group/db"
                  onClick={(e) => {
                    e.stopPropagation();
                    handleTechIconClick('database');
                  }}
                  onMouseEnter={() => setActiveTooltip('database')}
                  onMouseLeave={() => setActiveTooltip(null)}
                  title="Database expertise - Click for details"
                >
                  <span className="text-white text-xs">DB</span>
                  {activeTooltip === 'database' && (
                    <div className="absolute -top-16 left-1/2 transform -translate-x-1/2 bg-black text-white px-3 py-2 rounded-lg text-sm whitespace-nowrap z-50">
                      Database Expert (6+ years)
                      <div className="absolute top-full left-1/2 transform -translate-x-1/2 border-4 border-transparent border-t-black"></div>
                    </div>
                  )}
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>      {/* Scroll indicator */}
      <div className="absolute bottom-4 left-1/2 transform -translate-x-1/2 text-white animate-bounce">
        <svg className="w-6 h-6" fill="none" stroke="currentColor" viewBox="0 0 24 24">
          <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M19 14l-7 7m0 0l-7-7m7 7V3" />
        </svg>
      </div>

      {/* About Modal */}
      {showAboutModal && (
        <div className="fixed inset-0 bg-black/75 backdrop-blur-sm z-50 flex items-center justify-center p-4" onClick={() => setShowAboutModal(false)}>
          <div className="bg-white dark:bg-gray-800 rounded-2xl shadow-2xl max-w-2xl w-full max-h-[90vh] overflow-y-auto" onClick={(e) => e.stopPropagation()}>
            <div className="relative p-8">
              <button 
                onClick={() => setShowAboutModal(false)}
                className="absolute top-4 right-4 text-gray-500 hover:text-gray-700 dark:text-gray-400 dark:hover:text-gray-200 text-2xl"
              >
                ×
              </button>
              
              <div className="flex flex-col md:flex-row gap-6">
                <div className="md:w-1/3">
                  <img 
                    src={myPic} 
                    alt="Ali Safari" 
                    className="w-full rounded-xl shadow-lg"
                  />
                </div>
                
                <div className="md:w-2/3">
                  <h2 className="text-3xl font-bold text-gray-800 dark:text-gray-200 mb-4">About Ali Safari</h2>
                  
                  <div className="space-y-4 text-gray-600 dark:text-gray-400">
                    <p>
                      <strong className="text-gray-800 dark:text-gray-200">Full Stack Developer</strong> with 5+ years of experience 
                      building enterprise-grade applications using modern technologies.
                    </p>
                    
                    <p>
                      Passionate about creating scalable, maintainable software solutions with clean architecture 
                      principles. Experienced in leading development teams and delivering high-quality products.
                    </p>
                    
                    <div>
                      <h3 className="font-semibold text-gray-800 dark:text-gray-200 mb-2">Core Expertise:</h3>
                      <ul className="list-disc list-inside space-y-1">
                        <li>.NET Core & C# Backend Development</li>
                        <li>React & TypeScript Frontend Development</li>
                        <li>Database Design & Optimization</li>
                        <li>Cloud Architecture & DevOps</li>
                        <li>Data Analysis & Visualization</li>
                      </ul>
                    </div>
                    
                    <div className="flex gap-4 pt-4">
                      <Link 
                        to="https://pbk.asafarim.com" 
                        target="_blank"
                        className="px-6 py-2 bg-teal-600 text-white rounded-lg hover:bg-teal-700 transition-colors"
                      >
                        View Portfolio
                      </Link>
                      <Link 
                        to="/contact"
                        className="px-6 py-2 border border-teal-600 text-teal-600 rounded-lg hover:bg-teal-50 dark:hover:bg-teal-900/20 transition-colors"
                      >
                        Contact Me
                      </Link>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      )}

      {/* Skill Detail Modal */}
      {showSkillModal && techSkills[showSkillModal as keyof typeof techSkills] && (
        <div className="fixed inset-0 bg-black/75 backdrop-blur-sm z-50 flex items-center justify-center p-4" onClick={() => setShowSkillModal(null)}>
          <div className="bg-white dark:bg-gray-800 rounded-2xl shadow-2xl max-w-lg w-full" onClick={(e) => e.stopPropagation()}>
            <div className="relative p-8">
              <button 
                onClick={() => setShowSkillModal(null)}
                className="absolute top-4 right-4 text-gray-500 hover:text-gray-700 dark:text-gray-400 dark:hover:text-gray-200 text-2xl"
              >
                ×
              </button>
              
              {(() => {
                const skill = techSkills[showSkillModal as keyof typeof techSkills];
                return (
                  <div className="text-center">
                    <div className="text-6xl mb-4">
                      {skill.icon}
                    </div>
                    
                    <h2 className="text-2xl font-bold text-gray-800 dark:text-gray-200 mb-2">
                      {skill.name}
                    </h2>
                    
                    <p className="text-teal-600 dark:text-teal-400 font-semibold mb-4">
                      {skill.experience} Experience
                    </p>
                    
                    <p className="text-gray-600 dark:text-gray-400 mb-6">
                      {skill.description}
                    </p>
                    
                    <div className="text-left space-y-4">
                      <div>
                        <h3 className="font-semibold text-gray-800 dark:text-gray-200 mb-2">Recent Projects:</h3>
                        <ul className="list-disc list-inside text-sm text-gray-600 dark:text-gray-400 space-y-1">
                          {skill.projects.map((project, index) => (
                            <li key={index}>{project}</li>
                          ))}
                        </ul>
                      </div>
                      
                      <div>
                        <h3 className="font-semibold text-gray-800 dark:text-gray-200 mb-2">Certifications:</h3>
                        <ul className="list-disc list-inside text-sm text-gray-600 dark:text-gray-400 space-y-1">
                          {skill.certifications.map((cert, index) => (
                            <li key={index}>{cert}</li>
                          ))}
                        </ul>
                      </div>
                    </div>
                    
                    <div className="flex gap-3 mt-6">
                      <button 
                        onClick={() => handleSkillNavigation(skill.name)}
                        className="flex-1 px-4 py-2 bg-teal-600 text-white rounded-lg hover:bg-teal-700 transition-colors"
                      >
                        View {skill.name} Projects
                      </button>
                      <Link 
                        to="/contact"
                        className="flex-1 px-4 py-2 border border-teal-600 text-teal-600 rounded-lg hover:bg-teal-50 dark:hover:bg-teal-900/20 transition-colors text-center"
                      >
                        Discuss Project
                      </Link>
                    </div>
                  </div>
                );
              })()}
            </div>
          </div>
        </div>
      )}
    </div>
  );
};

export default HeroSection;
