import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-footer',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.scss']
})
export class FooterComponent {
  currentYear = new Date().getFullYear();
  
  socialLinks = [
    { name: 'LinkedIn', url: 'https://linkedin.com/in/ali-safari-m', icon: 'linkedin' },
    { name: 'GitHub', url: 'https://github.com/AliSafari-IT', icon: 'github' },
    { name: 'Google Scholar', url: 'https://scholar.google.com/citations?user=YZs9ktMAAAAJ', icon: 'google-scholar' },
    { name: 'ResearchGate', url: 'https://www.researchgate.net/profile/Alireza-Safari-3', icon: 'researchgate' }
  ];
  
  quickLinks = [
    { label: 'Home', path: '/' },
    { label: 'Resume', path: '/resume' },
    { label: 'Publications', path: '/publications' },
    { label: 'Research', path: '/research' }
  ];
}
