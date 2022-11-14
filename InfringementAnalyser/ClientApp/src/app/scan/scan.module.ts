import { NgModule } from "@angular/core";
import { AngularMaterialModule } from "../angular-material.module";
import { FlexLayoutModule } from "@angular/flex-layout";
import { CommonModule } from "@angular/common";
import { HomeComponent } from "./home/home.component";
import { NewScanComponent } from "./new-scan/new-scan.component";
import { RouterModule } from "@angular/router";
import { RecentScansComponent } from './recent-scans/recent-scans.component';
import { CompareFilesComponent } from './compare-files/compare-files.component';

@NgModule({
  declarations: [HomeComponent, NewScanComponent, RecentScansComponent, CompareFilesComponent],
  imports: [
    CommonModule,
    AngularMaterialModule,
    FlexLayoutModule,
    RouterModule,
  ],
})
export class ScanModule {}
