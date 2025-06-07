import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';

export type Theme = 'light' | 'dark';

@Injectable({
  providedIn: 'root'
})
export class ThemeService {
  private themeSubject: BehaviorSubject<Theme>;
  public theme$: Observable<Theme>;

  constructor() {
    // Initialize with the stored theme or default to light
    const storedTheme = localStorage.getItem('theme') as Theme || 'light';
    this.themeSubject = new BehaviorSubject<Theme>(storedTheme);
    this.theme$ = this.themeSubject.asObservable();
    
    // Apply the initial theme
    this.applyTheme(storedTheme);
  }

  private applyTheme(theme: Theme): void {
    document.documentElement.setAttribute('data-theme', theme);
    localStorage.setItem('theme', theme);
  }

  public getTheme(): Theme {
    return this.themeSubject.getValue();
  }

  public toggleTheme(): void {
    const currentTheme = this.themeSubject.getValue();
    const newTheme = currentTheme === 'light' ? 'dark' : 'light';
    
    this.themeSubject.next(newTheme);
    this.applyTheme(newTheme);
  }
}
