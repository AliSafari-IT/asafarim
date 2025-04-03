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
