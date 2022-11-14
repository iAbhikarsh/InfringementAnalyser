import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { LoginComponent } from "./login/login.component";
import { RegisterComponent } from "./register/register.component";
import { CompareFilesComponent } from "./scan/compare-files/compare-files.component";
import { HomeComponent } from "./scan/home/home.component";
import { NewScanComponent } from "./scan/new-scan/new-scan.component";
import { RecentScansComponent } from "./scan/recent-scans/recent-scans.component";

const routes: Routes = [
  {
    path: "login",
    component: LoginComponent,
  },
  {
    path: "register",
    component: RegisterComponent,
  },
  {
    path: "home",
    component: HomeComponent,
  },
  {
    path: "new",
    component: NewScanComponent,
  },
  {
    path: "recent-scans",
    component: RecentScansComponent,
  },
  {
    path: "compare-files",
    component: CompareFilesComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
