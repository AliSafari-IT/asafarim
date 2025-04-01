import { Component, OnInit } from '@angular/core';
import { ApiService } from '../../shared/services/api.service';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-portfolio-list',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './portfolio-list.component.html',
  styleUrls: ['./portfolio-list.component.scss']
})
export class PortfolioListComponent implements OnInit {
  portfolios: any[] = [];

  constructor(private api: ApiService) {}

  ngOnInit(): void {
    this.api.getAllPortfolios().subscribe((res) => (this.portfolios = res));
  }
}
