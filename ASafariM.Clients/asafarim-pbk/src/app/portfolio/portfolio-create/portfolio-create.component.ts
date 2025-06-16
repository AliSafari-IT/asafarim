import { Component } from '@angular/core';
import { ApiService } from '../../shared/services/api.service';
import { Router, RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-portfolio-create',
  standalone: true,
  imports: [CommonModule, FormsModule, RouterModule],
  templateUrl: './portfolio-create.component.html',
  styleUrls: ['./portfolio-create.component.scss']
})
export class PortfolioCreateComponent {
  model = { headline: '', biography: '', experienceMarkdown: '' };

  constructor(private api: ApiService, private router: Router) {}

  submit() {
    this.api.createPortfolio(this.model).subscribe(() => this.router.navigate(['/portfolios']));
  }
}
