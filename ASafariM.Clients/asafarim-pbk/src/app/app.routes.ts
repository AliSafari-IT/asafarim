import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { ResumeComponent } from './pages/resume/resume.component';
import { PublicationsComponent } from './pages/publications/publications.component';
import { ResearchComponent } from './pages/research/research.component';
import { PortfolioListComponent } from './portfolio/portfolio-list/portfolio-list.component';
import { PortfolioViewComponent } from './portfolio/portfolio-view/portfolio-view.component';
import { PortfolioCreateComponent } from './portfolio/portfolio-create/portfolio-create.component';
import { PortfolioEditComponent } from './portfolio/portfolio-edit/portfolio-edit.component';
import { PortfolioDeleteComponent } from './portfolio/portfolio-delete/portfolio-delete.component';

export const routes: Routes = [
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'home',
    redirectTo: '',
    pathMatch: 'full'
  },
  {
    path: 'resume',
    component: ResumeComponent
  },
  {
    path: 'publications',
    component: PublicationsComponent
  },
  {
    path: 'research',
    component: ResearchComponent
  },
  {
    path: 'portfolios',
    component: PortfolioListComponent
  },
  {
    path: 'portfolios/:userId',
    component: PortfolioViewComponent
  },
  {
    path: 'portfolio/:userId/create',
    component: PortfolioCreateComponent
  },
  {
    path: 'portfolio/:userId/edit',
    component: PortfolioEditComponent
  },
  {
    path: 'portfolio/:userId/delete',
    component: PortfolioDeleteComponent
  },
  {
    path: '**',
    redirectTo: ''
  }
];
