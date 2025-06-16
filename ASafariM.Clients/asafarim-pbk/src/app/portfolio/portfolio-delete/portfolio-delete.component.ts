import { Component } from '@angular/core';
import { ActivatedRoute, Router, RouterModule } from '@angular/router';
import { ApiService } from '../../shared/services/api.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-portfolio-delete',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './portfolio-delete.component.html',
  styleUrls: ['./portfolio-delete.component.scss']
})
export class PortfolioDeleteComponent {
  userId: string = '';

  constructor(private route: ActivatedRoute, private api: ApiService, private router: Router) {
    this.userId = this.route.snapshot.paramMap.get('userId')!;
  }

  confirmDelete() {
    this.api.deletePortfolio(this.userId).subscribe(() => this.router.navigate(['/portfolios']));
  }
}
