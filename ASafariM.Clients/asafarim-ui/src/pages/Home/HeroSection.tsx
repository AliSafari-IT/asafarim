import { Link } from "react-router-dom";
import myPic from "./ali_profile.jpg";
import React, { useState, useEffect } from "react";
import "./hero-animations.css";

const HeroSection = () => {
  const [mousePosition, setMousePosition] = useState({ x: 0, y: 0 });
  const [activeTooltip, setActiveTooltip] = useState<string | null>(null);
  const [activeSkillPanel, setActiveSkillPanel] = useState<string | null>(null);
  const [showAboutPanel, setShowAboutPanel] = useState(false);
  // Debug: log state changes
  useEffect(() => {
    console.log("activeSkillPanel changed:", activeSkillPanel);
  }, [activeSkillPanel]);

  useEffect(() => {
    const handleMouseMove = (e: MouseEvent) => {
      setMousePosition({ x: e.clientX, y: e.clientY });
    };

    window.addEventListener("mousemove", handleMouseMove);
    return () => window.removeEventListener("mousemove", handleMouseMove);
  }, []);

  // Close panel when pressing Escape
  useEffect(() => {
    const handleEscape = (e: KeyboardEvent) => {
      if (e.key === "Escape") {
        setActiveSkillPanel(null);
        setShowAboutPanel(false);
      }
    };

    document.addEventListener("keydown", handleEscape);
    return () => document.removeEventListener("keydown", handleEscape);
  }, []);
  const techSkills = {
    react: {
      name: "React",
      icon: "⚛️",
      color: "from-blue-400 to-cyan-500",
      bgColor: "bg-blue-50 dark:bg-blue-900/20",
      textColor: "text-blue-600 dark:text-blue-400",
      experience: "4+ years",
      level: 90,
      description:
        "Expert in building modern, responsive web applications with React, hooks, and state management.",
      projects: ["ASafariM UI", "Portfolio Website", "E-commerce Platform"],
      certifications: [
        "React Hooks",
        "JavaScript: Under the Hood",
        "React Fundamentals",
      ],
      technologies: [
        "React 18",
        "Redux Toolkit",
        "React Router",
        "Styled Components",
        "TailwindCSS",
        "TypeScript",
      ],
    },
    dotnet: {
      name: ".NET Core",
      icon: "🏗️",
      color: "from-purple-400 to-indigo-500",
      bgColor: "bg-purple-50 dark:bg-purple-900/20",
      textColor: "text-purple-600 dark:text-purple-400",
      experience: "3+ years",
      level: 90,
      description:
        "Proficient in building scalable backend APIs, microservices, and enterprise applications.",
      projects: [
        "ASafariM API",
        "Enterprise CRM",
        "Microservices Architecture",
      ],
      certifications: [
        "Software Design: From Requirements to Release",
        "Software Architecture: From Developer to Architect",
        "Designing RESTful APIs",
      ],
      technologies: [
        ".NET 8.x",
        ".NET 9.x",
        "Entity Framework",
        "ASP.NET Core",
        "SignalR",
        "Azure Functions",
      ],
    },
    database: {
      name: "Database Technologies",
      icon: "🗄️",
      color: "from-green-400 to-emerald-500",
      bgColor: "bg-green-50 dark:bg-green-900/20",
      textColor: "text-green-600 dark:text-green-400",
      experience: "3+ years",
      level: 85,
      description:
        "Experienced with MongoDB, MySQL, and familiar with PostgreSQL, and database design optimization.",
      projects: [
        "Data Analytics Platform",
        "User Management System",
        "E-commerce Database",
      ],
      certifications: [
        "SQL Fundamentals Course",
        "Processing and Interchanging JSON Data",
      ],
      technologies: ["MongoDB", "MySQL", "PostgreSQL", "Database Design"],
    },
    outofbox: {
      name: "Out-of-the-Box Solutions",
      icon: "📦",
      color: "from-pink-400 to-red-500",
      bgColor: "bg-pink-50 dark:bg-pink-900/20",
      textColor: "text-pink-600 dark:text-pink-400",
      experience: "2+ years",
      level: 75,
      description:
        "Skilled in implementing ready-made solutions and customizing them to fit client needs.",
      projects: ["E-commerce Platform Setup", "Content Management System"],
      certifications: [
        "Certified ScrumMaster",
        "Agile Project Management",
        "Strategic Thinking (2017)",
        "Improving Your Thinking",
      ],
      technologies: ["WordPress", "Shopify", "Laravel", "Python"],
    },
  };
  const handleProfileClick = () => {
    setShowAboutPanel(true);
  };

  const handleTechIconClick = (skillKey: string) => {
    console.log("Tech icon clicked:", skillKey);
    setActiveSkillPanel(skillKey);
  };
  return (
    <div className="relative h-[85vh] flex items-center justify-center">
      {/* Animated background */}
      <div className="absolute inset-0 bg-gradient-to-br from-teal-600 via-blue-700 to-purple-800">
        <div
          className="absolute inset-0 opacity-30"
          style={{
            background: `radial-gradient(600px at ${mousePosition.x}px ${mousePosition.y}px, rgba(29, 78, 216, 0.15), transparent 80%)`,
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
            <div className="flex flex-col sm:flex-row gap-6 justify-center lg:justify-start animate-fade-in-up">
              {" "}
              <Link
                to="https://pbk.asafarim.com"
                className="group px-8 py-4 bg-white text-teal-700 font-semibold rounded-xl shadow-xl hover:shadow-2xl transform hover:-translate-y-1 transition-all duration-300 text-lg flex items-center justify-center gap-2"
                target="_blank"
              >
                <span>View Portfolio</span>
                <svg
                  className="w-5 h-5 group-hover:translate-x-1 transition-transform"
                  fill="none"
                  stroke="currentColor"
                  viewBox="0 0 24 24"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    strokeWidth={2}
                    d="M17 8l4 4m0 0l-4 4m4-4H3"
                  />
                </svg>
              </Link>
              <Link
                to="/contact"
                className="group px-8 py-4 bg-transparent border-2 border-white text-white font-semibold rounded-xl hover:bg-white hover:text-teal-700 transform hover:-translate-y-1 transition-all duration-300 text-lg flex items-center justify-center gap-2"
              >
                <span>Hire Me</span>
                <svg
                  className="w-5 h-5 group-hover:scale-110 transition-transform"
                  fill="none"
                  stroke="currentColor"
                  viewBox="0 0 24 24"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    strokeWidth={2}
                    d="M8 12h.01M12 12h.01M16 12h.01M21 12c0 4.418-4.03 8-9 8a9.863 9.863 0 01-4.255-.949L3 20l1.395-3.72C3.512 15.042 3 13.574 3 12c0-4.418 4.03-8 9-8s9 3.582 9 8z"
                  />
                </svg>
              </Link>
            </div>
          </div>{" "}
          {/* Profile Image */}
          <div className="lg:w-2/5 flex justify-center">
            <div
              className="relative group cursor-pointer"
              onClick={handleProfileClick}
            >
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
                  className="absolute -top-4 -right-4 w-12 h-12 bg-white rounded-full shadow-lg flex items-center justify-center animate-bounce-slow cursor-pointer hover:scale-110 transition-transform duration-300 group/react z-10"
                  onClick={(e) => {
                    e.preventDefault();
                    e.stopPropagation();
                    e.nativeEvent.stopImmediatePropagation();
                    console.log("React icon clicked - preventing bubbling");
                    handleTechIconClick("react");
                    return false;
                  }}
                  onMouseEnter={() => setActiveTooltip("react")}
                  onMouseLeave={() => setActiveTooltip(null)}
                  title="React expertise - Click for details"
                >
                  <span className="text-2xl">⚛️</span>
                  {activeTooltip === "react" && (
                    <div className="absolute -top-16 left-1/2 transform -translate-x-1/2 bg-black text-white px-3 py-2 rounded-lg text-sm whitespace-nowrap z-50">
                      React Expert (4+ years)
                      <div className="absolute top-full left-1/2 transform -translate-x-1/2 border-4 border-transparent border-t-black"></div>
                    </div>
                  )}
                </div>

                <div
                  className="absolute -bottom-2 -left-4 w-10 h-10 bg-blue-500 rounded-full shadow-lg flex items-center justify-center animate-bounce-slow-delay cursor-pointer hover:scale-110 transition-transform duration-300 group/dotnet z-10"
                  onClick={(e) => {
                    e.preventDefault();
                    e.stopPropagation();
                    e.nativeEvent.stopImmediatePropagation();
                    console.log("Dotnet icon clicked - preventing bubbling");
                    handleTechIconClick("dotnet");
                    return false;
                  }}
                  onMouseEnter={() => setActiveTooltip("dotnet")}
                  onMouseLeave={() => setActiveTooltip(null)}
                  title=".NET Core expertise - Click for details"
                >
                  <span className="text-white font-bold text-sm">.NET</span>
                  {activeTooltip === "dotnet" && (
                    <div className="absolute -top-16 left-1/2 transform -translate-x-1/2 bg-black text-white px-3 py-2 rounded-lg text-sm whitespace-nowrap z-50">
                      .NET Expert (3+ years)
                      <div className="absolute top-full left-1/2 transform -translate-x-1/2 border-4 border-transparent border-t-black"></div>
                    </div>
                  )}
                </div>

                <div
                  className="absolute top-1/2 -right-6 w-8 h-8 bg-green-500 rounded-full shadow-lg flex items-center justify-center animate-pulse cursor-pointer hover:scale-110 transition-transform duration-300 group/db z-10"
                  onClick={(e) => {
                    e.preventDefault();
                    e.stopPropagation();
                    e.nativeEvent.stopImmediatePropagation();
                    console.log("Database icon clicked - preventing bubbling");
                    handleTechIconClick("database");
                    return false;
                  }}
                  onMouseEnter={() => setActiveTooltip("database")}
                  onMouseLeave={() => setActiveTooltip(null)}
                  title="Database expertise - Click for details"
                >
                  <span className="text-white text-xs">DB</span>
                  {activeTooltip === "database" && (
                    <div className="absolute -top-16 left-1/2 transform -translate-x-1/2 bg-black text-white px-3 py-2 rounded-lg text-sm whitespace-nowrap z-50">
                      Database Expert (3+ years)
                      <div className="absolute top-full left-1/2 transform -translate-x-1/2 border-4 border-transparent border-t-black"></div>
                    </div>
                  )}
                </div>
                <div
                  className="absolute bottom-0 left-1/2 transform -translate-x-1/2 w-10 h-10 bg-pink-500 rounded-full shadow-lg flex items-center justify-center animate-bounce-slow-delay cursor-pointer hover:scale-110 transition-transform duration-300 group/outofbox z-10"
                  onClick={(e) => {
                    e.preventDefault();
                    e.stopPropagation();
                    e.nativeEvent.stopImmediatePropagation();
                    console.log(
                      "Out-of-the-box icon clicked - preventing bubbling"
                    );
                    handleTechIconClick("outofbox");
                    return false;
                  }}
                  onMouseEnter={() => setActiveTooltip("outofbox")}
                  onMouseLeave={() => setActiveTooltip(null)}
                  title="Out-of-the-box solutions - Click for details"
                >
                  <span className="text-white text-lg">📦</span>
                  {activeTooltip === "outofbox" && (
                    <div className="absolute -top-16 left-1/2 transform -translate-x-1/2 bg-black text-white px-3 py-2 rounded-lg text-sm whitespace-nowrap z-50">
                      Out-of-the-Box Solutions (2+ years)
                      <div className="absolute top-full left-1/2 transform -translate-x-1/2 border-4 border-transparent border-t-black"></div>
                    </div>
                  )}
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>{" "}
      {/* Scroll indicator */}
      <div className="absolute bottom-4 left-1/2 transform -translate-x-1/2 text-white animate-bounce">
        <svg
          className="w-6 h-6"
          fill="none"
          stroke="currentColor"
          viewBox="0 0 24 24"
        >
          <path
            strokeLinecap="round"
            strokeLinejoin="round"
            strokeWidth={2}
            d="M19 14l-7 7m0 0l-7-7m7 7V3"
          />
        </svg>
      </div>
      {/* About Modal */}
      {showAboutPanel && (
        <div
          className="fixed inset-0 bg-black/75 backdrop-blur-sm z-50 flex items-center justify-center p-4"
          onClick={() => setShowAboutPanel(false)}
        >
          <div
            className="bg-white dark:bg-gray-800 rounded-2xl shadow-2xl max-w-2xl w-full max-h-[90vh] overflow-y-auto"
            onClick={(e) => e.stopPropagation()}
          >
            <div className="relative p-8">
              <button
                onClick={() => setShowAboutPanel(false)}
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
                  <h2 className="text-3xl font-bold text-gray-800 dark:text-gray-200 mb-4">
                    About Ali Safari
                  </h2>

                  <div className="space-y-4 text-gray-600 dark:text-gray-400">
                    <p>
                      <strong className="text-gray-800 dark:text-gray-200">
                        Full Stack Developer
                      </strong>{" "}
                      with 5+ years of experience building enterprise-grade
                      applications using modern technologies.
                    </p>

                    <p>
                      Passionate about creating scalable, maintainable software
                      solutions with clean architecture principles. Experienced
                      in leading development teams and delivering high-quality
                      products.
                    </p>

                    <div>
                      <h3 className="font-semibold text-gray-800 dark:text-gray-200 mb-2">
                        Core Expertise:
                      </h3>
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
      )}{" "}
      {/* Skill Details Sidebar Panel */}
      {activeSkillPanel && (
        <div className="fixed inset-0 z-50 pointer-events-none">
          {/* Backdrop */}
          <div
            className="absolute inset-0 bg-black/20 backdrop-blur-sm pointer-events-auto"
            onClick={() => setActiveSkillPanel(null)}
          />

          {/* Sidebar Panel */}
          <div
            className={`absolute right-0 top-0 h-full w-96 bg-white dark:bg-gray-900 shadow-2xl transform transition-transform duration-300 pointer-events-auto ${
              activeSkillPanel ? "translate-x-0" : "translate-x-full"
            }`}
          >
            <div className="p-6 h-full overflow-y-auto">
              {/* Close Button */}
              <button
                onClick={() => setActiveSkillPanel(null)}
                className="absolute top-4 right-4 p-2 rounded-full hover:bg-gray-100 dark:hover:bg-gray-800 transition-colors"
              >
                <svg
                  className="w-6 h-6"
                  fill="none"
                  stroke="currentColor"
                  viewBox="0 0 24 24"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    strokeWidth={2}
                    d="M6 18L18 6M6 6l12 12"
                  />
                </svg>
              </button>

              {/* Skill Content */}
              {activeSkillPanel &&
                techSkills[activeSkillPanel as keyof typeof techSkills] && (
                  <div className="mt-8">
                    <div
                      className={`inline-flex items-center gap-3 px-4 py-2 rounded-full ${
                        techSkills[activeSkillPanel as keyof typeof techSkills]
                          .bgColor
                      } mb-6`}
                    >
                      <span className="text-2xl">
                        {
                          techSkills[
                            activeSkillPanel as keyof typeof techSkills
                          ].icon
                        }
                      </span>
                      <h2
                        className={`text-2xl font-bold ${
                          techSkills[
                            activeSkillPanel as keyof typeof techSkills
                          ].textColor
                        }`}
                      >
                        {
                          techSkills[
                            activeSkillPanel as keyof typeof techSkills
                          ].name
                        }
                      </h2>
                    </div>

                    <div className="space-y-6">
                      <div>
                        <h3 className="text-lg font-semibold mb-2 text-gray-800 dark:text-gray-200">
                          Experience
                        </h3>
                        <p className="text-gray-600 dark:text-gray-400">
                          {
                            techSkills[
                              activeSkillPanel as keyof typeof techSkills
                            ].experience
                          }
                        </p>
                      </div>

                      <div>
                        <h3 className="text-lg font-semibold mb-2 text-gray-800 dark:text-gray-200">
                          Proficiency Level
                        </h3>
                        <div className="w-full bg-gray-200 dark:bg-gray-700 rounded-full h-3">
                          <div
                            className={`h-3 rounded-full bg-gradient-to-r ${
                              techSkills[
                                activeSkillPanel as keyof typeof techSkills
                              ].color
                            }`}
                            style={{
                              width: `${
                                techSkills[
                                  activeSkillPanel as keyof typeof techSkills
                                ].level
                              }%`,
                            }}
                          />
                        </div>
                        <span className="text-sm text-gray-600 dark:text-gray-400 mt-1 block">
                          {
                            techSkills[
                              activeSkillPanel as keyof typeof techSkills
                            ].level
                          }
                          %
                        </span>
                      </div>

                      <div>
                        <h3 className="text-lg font-semibold mb-2 text-gray-800 dark:text-gray-200">
                          Description
                        </h3>
                        <p className="text-gray-600 dark:text-gray-400">
                          {
                            techSkills[
                              activeSkillPanel as keyof typeof techSkills
                            ].description
                          }
                        </p>
                      </div>

                      <div>
                        <h3 className="text-lg font-semibold mb-2 text-gray-800 dark:text-gray-200">
                          Key Technologies
                        </h3>
                        <div className="flex flex-wrap gap-2">
                          {techSkills[
                            activeSkillPanel as keyof typeof techSkills
                          ].technologies.map((tech, index) => (
                            <span
                              key={index}
                              className="px-3 py-1 bg-gray-100 dark:bg-gray-800 rounded-full text-sm text-gray-700 dark:text-gray-300"
                            >
                              {tech}
                            </span>
                          ))}
                        </div>
                      </div>

                      <div>
                        <h3 className="text-lg font-semibold mb-2 text-gray-800 dark:text-gray-200">
                          Featured Projects
                        </h3>
                        <ul className="space-y-2">
                          {techSkills[
                            activeSkillPanel as keyof typeof techSkills
                          ].projects.map((project, index) => (
                            <li
                              key={index}
                              className="flex items-center gap-2 text-gray-600 dark:text-gray-400"
                            >
                              <span className="w-2 h-2 bg-teal-500 rounded-full" />
                              {project}
                            </li>
                          ))}
                        </ul>
                      </div>

                      {techSkills[activeSkillPanel as keyof typeof techSkills]
                        .certifications && (
                        <div>
                          <h3 className="text-lg font-semibold mb-2 text-gray-800 dark:text-gray-200">
                            Certifications
                          </h3>
                          <ul className="space-y-2">
                            {techSkills[
                              activeSkillPanel as keyof typeof techSkills
                            ].certifications.map((cert, index) => (
                              <li
                                key={index}
                                className="flex items-center gap-2 text-gray-600 dark:text-gray-400"
                              >
                                <span className="w-2 h-2 bg-green-500 rounded-full" />
                                {cert}
                              </li>
                            ))}
                          </ul>
                        </div>
                      )}
                    </div>
                  </div>
                )}
            </div>
          </div>
        </div>
      )}
    </div>
  );
};

export default HeroSection;
