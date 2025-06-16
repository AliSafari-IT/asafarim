import { Component, OnInit, OnDestroy } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ThemeService, Theme } from '../../services/theme.service';
import { Subscription } from 'rxjs';

interface EducationEntry {
  degree: string;
  institution: string;
  location?: string;
  period?: string;
  year?: string;
  description: string;
  skills?: string[];
  achievements?: string[];
}

interface ExperienceEntry {
  title: string;
  company: string;
  location?: string;
  period: string;
  description: string;
  skills: string[];
  achievements?: string[];
  projects?: Array<{
    name: string;
    description: string;
    technologies: string[];
    achievements?: string[];
  }>;
  technologies?: {
    backend: string[];
    frontend: string[];
    databases: string[];
  };
}

interface SkillCategory {
  category: string;
  items: string[];
  description: string;
}

interface Language {
  name: string;
  level: string;
}

interface ProjectLink {
  name: string;
  url: string;
  description: string;
}

interface Certification {
  name: string;
  issuer: string;
  issuedDate: string;
  credentialId?: string;
  credentialUrl?: string;
  logo?: string;
}

@Component({
  selector: 'app-resume',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './resume.component.html',
  styleUrls: ['./resume.component.scss']
})
export class ResumeComponent implements OnInit, OnDestroy {
  pageTitle = 'Ali Safari - Resume & Experience';
  theme: Theme = 'light';
  private themeSubscription: Subscription = Subscription.EMPTY;

  constructor(private themeService: ThemeService) { }

  ngOnInit() {
    // Subscribe to theme changes
    this.themeSubscription = this.themeService.theme$.subscribe(
      currentTheme => {
        this.theme = currentTheme;
      }
    );

    // Load LinkedIn badge script
    this.loadLinkedInScript();
  }

  private loadLinkedInScript(): void {
    const script = document.createElement('script');
    script.src = 'https://platform.linkedin.com/badges/js/profile.js';
    script.async = true;
    script.defer = true;
    document.body.appendChild(script);
  }

  /**
   * Process the profile image for the downloaded HTML file
   * Attempts to make the image look more decent in the downloaded file
   */
  private processProfileImage(resumeElement: HTMLElement): void {
    // Find the profile image
    const profileImg = resumeElement.querySelector('.profile-image img') as HTMLImageElement;

    if (profileImg) {
      // Ensure the image has proper styling
      profileImg.style.width = '100%';
      profileImg.style.height = '100%';
      profileImg.style.objectFit = 'cover';
      profileImg.style.borderRadius = '50%';

      // If the image is a relative path, convert to absolute URL
      if (profileImg.src.startsWith('/') || !profileImg.src.startsWith('http')) {
        const baseUrl = window.location.origin;
        profileImg.src = new URL(profileImg.src, baseUrl).href;
      }

      // Add a fallback image in case the original doesn't load
      profileImg.onerror = () => {
        profileImg.src = 'data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxMjgiIGhlaWdodD0iMTI4IiB2aWV3Qm94PSIwIDAgMjU2IDI1NiI+PHJlY3Qgd2lkdGg9IjI1NiIgaGVpZ2h0PSIyNTYiIGZpbGw9IiNlOWVjZWYiLz48Y2lyY2xlIGN4PSIxMjgiIGN5PSI5NiIgcj0iNjQiIGZpbGw9IiNhYmI1YmUiLz48Y2lyY2xlIGN4PSIxMjgiIGN5PSIyMjQiIHI9IjEyOCIgZmlsbD0iI2FiYjViZSIvPjwvc3ZnPg==';
      };
    }

    // Fix SVG icons if needed
    const svgIcons = resumeElement.querySelectorAll('svg');
    svgIcons.forEach(svg => {
      if (svg.getAttribute('width') === null) {
        svg.setAttribute('width', '16');
      }
      if (svg.getAttribute('height') === null) {
        svg.setAttribute('height', '16');
      }
    });

    // Fix other image icons
    const icons = resumeElement.querySelectorAll('.icon');
    icons.forEach(icon => {
      if (icon instanceof HTMLImageElement) {
        const img = icon as HTMLImageElement;
        if (img.src.startsWith('/') || !img.src.startsWith('http')) {
          const baseUrl = window.location.origin;
          img.src = new URL(img.src, baseUrl).href;
        }
      }
    });
  }

  /**
   * Generates and downloads the resume as an HTML file
   */
  downloadResume(): void {
    // Get the resume content
    const resumeSection = document.querySelector('.resume-section') as HTMLElement;

    if (resumeSection) {
      // Clone the element to avoid modifying the displayed content
      const clonedResume = resumeSection.cloneNode(true) as HTMLElement;

      // Remove elements with 'no-print' class
      const noPrintElements = clonedResume.querySelectorAll('.no-print');
      noPrintElements.forEach(element => element.remove());

      // Fix profile image - convert to embedded base64 if possible
      this.processProfileImage(clonedResume);

      // Create a complete HTML document
      const htmlContent = `
        <!DOCTYPE html>
        <html lang="en">
        <head>
          <meta charset="UTF-8">
          <meta name="viewport" content="width=device-width, initial-scale=1.0">
          <title>Ali Safari - Resume</title>
          <style>
            /* Include essential styles */
            body {
              font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
              margin: 0;
              padding: 0;
              background-color: white;
              color: #333;
            }
            
            /* Copy your essential resume styles here */
            .resume-section {
              padding: 2rem 0;
              background-color: white;
            }
            
            .container {
              max-width: 1000px;
              margin: 0 auto;
              padding: 0 1.5rem;
            }
            
            .resume-layout {
              display: flex;
              flex-direction: row;
              border-radius: 8px;
              overflow: hidden;
            }
            
            .resume-left-column {
              width: 240px;
              padding: 1.5rem;
              background-color: #f5f7fa;
            }
            
            .resume-right-column {
              flex: 1;
              padding: 1.5rem;
              background-color: white;
            }
            
            /* Profile image styles */
            .profile-image-container {
              margin-bottom: 1.5rem;
              display: flex;
              flex-direction: column;
              align-items: center;
              width: 100%;
            }
            
            .profile-image {
              width: 120px;
              height: 120px;
              border-radius: 50%;
              overflow: hidden;
              border: 3px solid #0ea5e9;
              padding: 3px;
              background-color: white;
              box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
              margin-bottom: 1.25rem;
            }
            
            .avatar {
              width: 100%;
              height: 100%;
              object-fit: cover;
              border-radius: 50%;
            }
            
            .profile-name {
              font-size: 1.75rem;
              font-weight: 700;
              margin-bottom: 0.25rem;
              line-height: 1.2;
              text-align: center;
              color: #3b82f6;
            }
            
            .profile-title {
              font-size: 1rem;
              margin-bottom: 1.5rem;
              font-weight: 500;
              text-align: center;
              color: #0ea5e9;
            }
            
            .section-title {
              font-size: 1.4rem;
              font-weight: 700;
              color: #0ea5e9;
              margin-bottom: 1rem;
              padding-bottom: 0.5rem;
              border-bottom: 2px solid #e2e8f0;
            }
            
            /* Sidebar styles */
            .sidebar-section {
              width: 100%;
              margin-bottom: 1.5rem;
            }
            
            .sidebar-title {
              font-size: 1.1rem;
              font-weight: 600;
              margin-bottom: 0.75rem;
              border-bottom: 2px solid #e2e8f0;
              padding-bottom: 0.5rem;
            }
            
            .languages-list {
              display: flex;
              flex-direction: column;
              gap: 0.5rem;
            }
            
            .language-item {
              display: flex;
              align-items: center;
              justify-content: space-between;
              padding: 0.25rem 0;
              font-size: 0.9rem;
            }
            
            .language-name {
              font-weight: 600;
              color: #0ea5e9;
            }
            
            .language-level {
              font-weight: 500;
              color: #3b82f6;
            }
            
            /* Print specific styles */
            .print-only {
              display: block;
            }
            
            /* Timeline styles */
            .education-timeline-container,
            .experience-timeline-container {
              position: relative;
              padding-left: 30px;
              margin-left: 20px;
            }
            
            .timeline-vertical-line {
              position: absolute;
              top: 0;
              bottom: 0;
              left: 0;
              width: 2px;
              background-color: #dee2e6;
            }
            
            .timeline-marker {
              position: absolute;
              left: -30px;
              top: 15px;
            }
            
            .timeline-dot {
              width: 16px;
              height: 16px;
              border-radius: 50%;
              background-color: #3b82f6;
              border: 3px solid white;
              box-shadow: 0 0 0 2px #dee2e6;
            }
            
            .education-card,
            .experience-card,
            .key-skill-item,
            .certification-item {
              background-color: #f7f9fc;
              border-radius: 8px;
              padding: 1rem;
              border: 1px solid #dee2e6;
              margin-bottom: 1rem;
            }
            
            .skill-tag,
            .tech-tag,
            .edu-skill-tag {
              font-size: 0.8rem;
              color: #3b82f6;
              background-color: rgba(59, 130, 246, 0.1);
              padding: 0.2rem 0.6rem;
              border-radius: 100px;
              display: inline-block;
              margin: 0.2rem;
            }
            
            .key-skill-row {
              display: flex;
              flex-direction: row;
              gap: 1.5rem;
            }
            
            .key-skill-category {
              width: 150px;
              flex-shrink: 0;
            }
            
            .key-skill-content {
              flex: 1;
            }
            
            .key-skill-tags,
            .experience-tech,
            .skills-container {
              display: flex;
              flex-wrap: wrap;
              gap: 0.5rem;
            }
            
            /* Icon styles */
            .icon {
              width: 16px;
              height: 16px;
            }
            
            /* Add Font Awesome for icons */
            .fas, .far {
              margin-right: 0.5rem;
            }
            
            /* Flex utilities */
            .flex { display: flex; }
            .justify-between { justify-content: space-between; }
            .items-center { align-items: center; }
            .space-y-2 > * + * { margin-top: 0.5rem; }
            .space-y-3 > * + * { margin-top: 0.75rem; }
            
            /* Add more specific styles as needed */
            @media print {
              body {
                font-size: 12pt;
              }
              .resume-section {
                padding: 0;
              }
            }
          </style>
          <!-- Add Font Awesome for icons -->
          <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css">
        </head>
        <body>
          ${clonedResume.outerHTML}
        </body>
        </html>
      `;

      // Create a blob and download
      const blob = new Blob([htmlContent], { type: 'text/html' });
      const url = URL.createObjectURL(blob);
      const anchor = document.createElement('a');
      anchor.href = url;
      anchor.download = 'ali-safari-resume.html';
      anchor.click();

      // Clean up
      URL.revokeObjectURL(url);
    }
  }

  ngOnDestroy() {
    // Unsubscribe to prevent memory leaks
    if (this.themeSubscription) {
      this.themeSubscription.unsubscribe();
    }
  }

  personalInfo = {
    name: 'Alireza Safari',
    title: 'Full-Stack .NET & React Developer | Clean Architecture | AI & Data Enthusiast',
    profileImage: 'assets/images/profile.jpg',
    summary: 'A versatile software developer specializing in React, TypeScript, C#, SQL/NoSQL databases, and .NET Core. Strong foundation in Hydrology Engineering and model calibration. Skilled in crafting scalable, maintainable, and interactive software solutions. Passionate about data management, artificial intelligence, and delivering high-quality code.',
    languages: [
      { name: 'English', level: 'Proficient' },
      { name: 'Persian', level: 'Native' },
      { name: 'Dutch', level: 'B2' }
    ] as Language[]
  };

  experiences: ExperienceEntry[] = [
    {
      title: 'Scientific App Developer',
      company: 'XiTechniX (Unlimit-IT)',
      location: 'Geel, Belgium',
      period: 'December 2020 - December 2023',
      description: 'Full-stack software development for scientific applications, focusing on comprehensive technology solutions across frontend, backend, and database domains.',
      skills: [
        '.NET Core', 'ASP.NET Core', 'WebAPI', 'MVC',
        'Entity Framework Core', 'React', 'TypeScript',
        'Syncfusion', 'MongoDB', 'SQL Server', 'MySQL'
      ],
      technologies: {
        backend: ['.NET Core', 'ASP.NET Core', 'WebAPI', 'MVC', 'Entity Framework Core'],
        frontend: ['React', 'TypeScript', 'Syncfusion', 'CSS Frameworks'],
        databases: ['MongoDB', 'SQL Server', 'MySQL']
      },
      projects: [
        {
          name: 'Humqu Platform',
          description: 'Collaborative development of platform components using React, .NET Core services, and MongoDB',
          technologies: ['React', '.NET Core', 'MongoDB'],
          achievements: ['Enhanced team-based development skills']
        },
        {
          name: 'Normec Group Projects',
          description: 'Full project lifecycle management for TypeScript React modules',
          technologies: ['TypeScript', 'React'],
          achievements: [
            'Developed Process Stations configurations',
            'Created Markup ReportType implementations',
            'Managed complete project delivery cycle'
          ]
        },
        {
          name: '"Humster" Automated Testing Framework',
          description: 'Contributed to creating an end-to-end automated testing system',
          technologies: ['Test Automation', 'TestC'],
          achievements: ['Implemented comprehensive automated testing solutions']
        }
      ],
      achievements: [
        'Demonstrated expertise in full-stack development across multiple technology stacks',
        'Successfully delivered complex scientific and business software solutions',
        'Improved development processes through advanced testing and integration techniques'
      ]
    },
    {
      title: 'Data Visualization Developer (Internship)',
      company: 'IRC Engineering',
      location: 'Dendermonde, Belgium',
      period: 'a monthly basis internship (2020)',
      description: 'Developing data visualization solutions',
      achievements: [
        'Energy Consumption Time series analysis and visualization',
        'Utilized C# and R.Net to create Windows Presentation Foundation (WPF) applications'
      ],
      skills: ['WPF', 'C#', 'R', 'R.NET', '.NET']
    },
    {
      title: 'Hydrologic Modeling & Development (Internship)',
      company: 'Flanders Environment Agency (VMM)',
      location: 'Brussels, Belgium',
      period: '2018 - 2019',
      description: 'Developing hydrologic model WetSpa and scientific programming within a research-driven environmental context.',
      skills: ['FORTRAN', 'Hydrologic Modeling', 'Scientific Programming', 'River Flow Simulation'],
      achievements: [
        'Adapted and enhanced the WetSpa hydrologic model for river flow simulations',
        'Leveraged advanced scientific programming skills in environmental research',
        'Contributed to innovative hydrologic modeling techniques'
      ]
    }
  ];

  education: EducationEntry[] = [
    {
      degree: 'Informatics - Programming',
      institution: 'Thomas More Campus De Nayer',
      location: 'Sint-Katelijne-Waver, Belgium',
      period: '2018 - 2020',
      description: 'Focused on programming principles, full-stack development, and database management.',
      skills: ['C#', '.NET', 'JavaScript', 'Full-Stack Development', 'Database Management'],
      achievements: [
        'Gained practical experience with C# and .NET technologies',
        'Developed skills in building responsive applications',
        'Deepened understanding of programming principles and database management'
      ]
    },
    {
      degree: 'Ph.D. in Engineering - Hydrology',
      institution: 'Vrije Universiteit Brussel (VUB)',
      location: 'Belgium',
      period: '2005 - 2012',
      description: 'Advanced hydrologic modeling research integrating big data analytics from environmental data sources.',
      skills: [
        'Hydrologic Modeling (WetSpa distributed model)',
        'Numerical River Flow Modeling',
        'Radar & Satellite Data Analysis',
        'Developed Automated Model calibration technique (ARIMA based time series analysis)',
        'Model prediction and validation'
      ],
      achievements: [
        'Conducted advanced research in hydrologic modeling',
        'Integrated big data analytics to improve environmental model accuracy',
        'Developed expertise in statistical modeling and data-driven solutions',
        'Enhanced understanding of environmental data analysis techniques'
      ]
    },
    {
      degree: 'M.Sc. & B.Sc. in Hydrology & Natural Resources Engineering',
      institution: 'University of Tehran',
      location: 'Iran',
      period: '1994 - 2001',
      description: 'Comprehensive education in hydrologic engineering and environmental modeling.',
      skills: [
        'Flood Zone Analysis and Mapping (GIS)',
        'Natural Resources Management',
        'Flood Risk Analysis',
        'Hec-RAS (Hydraulic Engineering Computing - River Analysis System) modeling'
      ],
      achievements: [
        'Developed foundational knowledge in hydrologic engineering',
        'Gained expertise in environmental modeling techniques',
        'Built strong background for scientific software modeling'
      ]
    }
  ];

  skills: SkillCategory[] = [
    {
      category: 'Programming Languages',
      items: [
        'C# (ASP.NET Core, .NET Framework)',
        'TypeScript',
        'JavaScript'
      ],
      description: 'Mastering multiple programming languages for building robust applications.'
    },
    {
      category: 'Frontend Development',
      items: [
        'React with TypeScript',
        'Redux State Management',
        'Syncfusion UI Components',
        'Tailwind CSS',
        'SASS Styling'
      ],
      description: 'Mastering frontend development with React and TypeScript.'
    },
    {
      category: 'Backend Development',
      items: [
        'ASP.NET Core (WebAPI, MVC)',
        'Entity Framework Core',
        'SignalR Real-Time Features'
      ],
      description: 'Mastering backend development with ASP.NET Core and Entity Framework.'
    },
    {
      category: 'Data Visualization & Analytics',
      items: [
        'D3.js Data Visualizations',
        'R',
        'R.Net Data Processing'
      ],
      description: 'Mastering data visualization and analytics with D3.js and R.'
    },
    {
      category: 'Database Management',
      items: [
        'SQL Server',
        'MySQL',
        'MongoDB',
        'Database Design and Optimization'
      ],
      description: 'Mastering database management with SQL Server, MySQL, and MongoDB.'
    },
    {
      category: 'Testing & Quality Assurance',
      items: [
        'xUnit',
        'Moq',
        'TestCafe End-to-End Testing'
      ],
      description: 'Mastering testing and quality assurance with xUnit and Moq.'
    },
    {
      category: 'Version Control & DevOps',
      items: [
        'Git',
        'GitHub',
        'Azure DevOps',
        'Docker'
      ],
      description: 'Mastering version control and DevOps with Git, GitHub, and Azure DevOps.'
    },
    {
      category: 'API & Documentation',
      items: [
        'Swagger UI',
        'RESTful API Development'
      ],
      description: 'Mastering API development and documentation with Swagger UI.'
    },
    {
      category: 'Content Management',
      items: [
        'WordPress Development'
      ],
      description: 'Mastering content management with WordPress development.'
    }
  ];

  myProjectLinks: ProjectLink[] = [
    {
      name: 'Full Stack ASafariM React Typescript & C# .Net Core 9 Web Application',
      url: 'https://asafarim.com',
      description: 'ReactTypescript C# .Net Core 9 web application deployed to a VPS hosting server',
    },
    {
      name: 'React Typescript & Redux Web Application',
      url: 'https://bibliography.asafarim.com',
      description: 'ReactTypescript C# .Net Core 9 web application deployed to a VPS hosting server'
    },
    {
      name: 'Technical Documentation (Single Page Application)',
      url: 'https://blog.asafarim.com',
      description: 'Developed a comprehensive technical documentation Single Page Application (SPA) using React, TypeScript, and Docusaurus, demonstrating expertise in modern documentation frameworks and static site generation'
    },
    {
      name: 'Multi-User Portfolio Builder Kit (AsafarimPbk) (WIP, Angular 19)',
      url: 'https://github.com/AliSafari-IT/asafarim/tree/main/ASafariM.Clients/asafarim-pbk',
      description: 'A modular, fullstack Angular + .NET 9 clean architecture solution designed to empower authenticated users to build and manage their own portfolio pages.'
    },
    {
      name: 'IGS Pharma WordPress Site',
      url: 'https://igs-pharma.com/',
      description: 'WordPress web application showcasing CMS development skills'
    }
  ];

  certifications: Certification[] = [
    {
      name: "JavaScript: Under the Hood",
      issuer: 'LinkedIn',
      issuedDate: 'Sep 2022',
      credentialUrl: 'https://www.linkedin.com/learning/certificates/5bc51a6b570d17e116d8e19f56a406910c1a020ff185bc44b5b8ed22037025b5'
    },
    {
      name: 'Improving Your Thinking',
      issuer: 'LinkedIn',
      issuedDate: 'Jun 2021',
      credentialUrl: 'https://www.linkedin.com/learning/certificates/1b39b52115ce87e9626c6a706d877c13e10666def00649987ae359d91b1129ed?trk=backfilled_certificate'
    },
    {
      name: 'Learning PowerShell',
      issuer: 'LinkedIn',
      issuedDate: 'Jun 2021',
      credentialUrl: 'https://www.linkedin.com/learning/certificates/82c6da51bfc025f0817af2b5ad114abf9479d98e9e0a95b96fabb1ff89cb62a5?trk=backfilled_certificate'
    },
    {
      name: 'Processing and Interchanging JSON Data',
      issuer: 'LinkedIn',
      issuedDate: 'Jun 2021',
      credentialUrl: 'https://www.linkedin.com/learning/certificates/3fe348c3cd7d2d30367013facf2058fd7ce942350ed5e19b44b9b35b3e23f06d?trk=backfilled_certificate'
    },
    {
      name: 'Software Architecture: From Developer to Architect',
      issuer: 'LinkedIn',
      issuedDate: 'Jun 2021',
      credentialUrl: 'https://www.linkedin.com/learning/certificates/38164508dec1b8483f6c7cbdb59fdbba3dee84965b46fdeee8bbef65a00a2460?trk=backfilled_certificate'
    },
    {
      name: 'Software Design: From Requirements to Release',
      issuer: 'LinkedIn',
      issuedDate: 'Jun 2021',
      credentialUrl: 'https://www.linkedin.com/learning/certificates/b0584ced722583b2e13fa6ea333d0cdc057fbc323ba6a78cd8e575e98918b74e?trk=backfilled_certificate'
    },
    {
      name: 'React Hooks',
      issuer: 'LinkedIn',
      issuedDate: 'May 2021',
      credentialUrl: 'https://www.linkedin.com/learning/certificates/1fd445e960cfabe1d07f1d6b96e0d9f6b393850a625567412566a522852f0f09?trk=backfilled_certificate'
    },
    {
      name: 'Java Tutorial Course',
      issuer: 'SoloLearn',
      issuedDate: 'Jun 2019',
      credentialId: '#1068-10277597',
      credentialUrl: 'https://www.sololearn.com/Certificate/CT-IRBENPDK/pdf'
    },
    {
      name: 'HTML Fundamental Course',
      issuer: 'SoloLearn',
      issuedDate: 'May 2019',
      credentialId: '#1014-10277597',
      credentialUrl: 'https://www.sololearn.com/Certificate/CT-6LITKXKL/pdf'
    },
    {
      name: 'SQL Fundamentals Course',
      issuer: 'SoloLearn',
      issuedDate: 'May 2019',
      credentialId: '#1060-10277597',
      credentialUrl: 'https://www.sololearn.com/Certificate/CT-BX7LCOEN/pdf'
    }
  ];
}
