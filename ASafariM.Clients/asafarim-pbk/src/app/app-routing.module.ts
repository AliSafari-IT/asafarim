import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { PortfolioCreateComponent } from "./portfolio/portfolio-create/portfolio-create.component";
import { PortfolioDeleteComponent } from "./portfolio/portfolio-delete/portfolio-delete.component";
import { PortfolioEditComponent } from "./portfolio/portfolio-edit/portfolio-edit.component";
import { PortfolioListComponent } from "./portfolio/portfolio-list/portfolio-list.component";
import { PortfolioViewComponent } from "./portfolio/portfolio-view/portfolio-view.component";

const routes: Routes = [
    { path: 'portfolios', component: PortfolioListComponent },
    { path: 'portfolios/:userId', component: PortfolioViewComponent },
    { path: 'portfolio/:userId/create', component: PortfolioCreateComponent },
    { path: 'portfolio/:userId/edit', component: PortfolioEditComponent },
    { path: 'portfolio/:userId/delete', component: PortfolioDeleteComponent },
    { path: '', redirectTo: 'portfolios', pathMatch: 'full' }
  ];

  @NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
  })
  export class AppRoutingModule { }