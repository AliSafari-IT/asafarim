import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

interface Service {
  title: string;
  description: string;
  icon: string;
  iconClass: string;
}

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {
  pageTitle = 'Ali Safari - IT Developer';
  services: Service[] = [
{
  title: 'Full-Stack .NET & React Development',
  description: 'Architecting end-to-end solutions with clean architecture, leveraging .NET Core, React, and modern cloud technologies for scalable enterprise applications.',
  icon: 'fas fa-code-branch',
  iconClass: 'fullstack-dev-icon'
},
{
  title: 'Web Development',
  description: 'Creating responsive and performant web applications using modern frameworks.',
  icon: 'fas fa-laptop-code',
  iconClass: 'web-dev-icon'
},
{
  title: 'Environmental Data Engineering',
  description: 'Transforming complex environmental data into actionable insights using advanced modeling, machine learning, and geospatial technologies.',
  icon: 'fas fa-globe-americas',
  iconClass: 'environmental-solutions-icon'
},
{
  title: 'Scientific Software Development Consultant',
  description: 'Bridging hydrology expertise with software engineering to develop innovative technological solutions for scientific and environmental applications.',
  icon: 'fas fa-flask',
  iconClass: 'scientific-consulting-icon'
}
  ];
}
