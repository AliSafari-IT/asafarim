import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ApiService } from '../../shared/services/api.service';
import { CommonModule } from '@angular/common';
import { MarkdownComponent } from '../../shared/components/markdown';

@Component({
  selector: 'app-portfolio-view',
  standalone: true,
  imports: [CommonModule, MarkdownComponent],
  templateUrl: './portfolio-view.component.html',
  styleUrls: ['./portfolio-view.component.scss']
})
export class PortfolioViewComponent implements OnInit {
  @Input() userId!: string;
  portfolio: any;

  constructor(private route: ActivatedRoute, private api: ApiService) {}

  ngOnInit(): void {
    this.userId = this.route.snapshot.paramMap.get('userId')!;
    this.api.getPortfolioByUserId(this.userId).subscribe(res => this.portfolio = res);
  }
}
