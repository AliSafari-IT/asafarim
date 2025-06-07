import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'markdown',
  standalone: true,
  imports: [CommonModule],
  template: '<div [innerHTML]="renderedContent"></div>',
  styles: []
})
export class MarkdownComponent implements OnChanges {
  @Input() data: string = '';
  renderedContent: string = '';

  ngOnChanges(changes: SimpleChanges): void {
    if (changes['data']) {
      // Simple markdown-like rendering (just for demonstration)
      // In a real app, you would use a proper markdown library after installing it
      this.renderedContent = this.data ? this.simpleMarkdownToHtml(this.data) : '';
    }
  }

  private simpleMarkdownToHtml(markdown: string): string {
    // This is a very basic implementation
    // Replace paragraphs (lines with a blank line before and after)
    let html = markdown.replace(/\n\n(.+?)\n\n/g, '<p>$1</p>');
    
    // Replace headers
    html = html.replace(/^# (.+)$/gm, '<h1>$1</h1>');
    html = html.replace(/^## (.+)$/gm, '<h2>$1</h2>');
    html = html.replace(/^### (.+)$/gm, '<h3>$1</h3>');
    
    // Replace bold
    html = html.replace(/\*\*(.+?)\*\*/g, '<strong>$1</strong>');
    
    // Replace italic
    html = html.replace(/\*(.+?)\*/g, '<em>$1</em>');
    
    // Replace links
    html = html.replace(/\[(.+?)\]\((.+?)\)/g, '<a href="$2">$1</a>');
    
    return html;
  }
}
