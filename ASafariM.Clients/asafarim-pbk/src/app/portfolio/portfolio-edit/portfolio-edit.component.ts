import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router, RouterModule } from '@angular/router';
import { ApiService } from '../../shared/services/api.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-portfolio-edit',
  standalone: true,
  imports: [CommonModule, FormsModule, RouterModule],
  templateUrl: './portfolio-edit.component.html',
  styleUrls: ['./portfolio-edit.component.scss']
})
export class PortfolioEditComponent implements OnInit {
  portfolio: any = {};
  userId: string = '';

  constructor(private route: ActivatedRoute, private api: ApiService, private router: Router) {}

  ngOnInit(): void {
    this.userId = this.route.snapshot.paramMap.get('userId')!;
    this.api.getPortfolioByUserId(this.userId).subscribe(res => this.portfolio = res);
  }

  save() {
    this.api.updatePortfolio(this.userId, this.portfolio).subscribe(() =>
      this.router.navigate(['/portfolios', this.userId])
    );
  }
}
