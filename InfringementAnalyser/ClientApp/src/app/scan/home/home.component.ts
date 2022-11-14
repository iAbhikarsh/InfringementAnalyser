import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-home",
  templateUrl: "./home.component.html",
  styleUrls: ["./home.component.css"],
})
export class HomeComponent implements OnInit {
  currentUser: string;

  constructor() {}

  ngOnInit(): void {
    const users = JSON.parse(localStorage.getItem("users") || "{}");
    this.currentUser = users.userName;
  }
}
