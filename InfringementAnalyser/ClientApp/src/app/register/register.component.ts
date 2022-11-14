import { Component, OnInit } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { MatSnackBar } from "@angular/material/snack-bar";
import { Router } from "@angular/router";
import { User } from "../../datasource/users";
import { UserService } from "../../services/user.service";

@Component({
  selector: "app-register",
  templateUrl: "./register.component.html",
  styleUrls: ["./register.component.css"],
})
export class RegisterComponent implements OnInit {
  registerFormGroup: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private userService: UserService,
    private _snackBar: MatSnackBar,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.setupForm();
  }

  setupForm(): void {
    this.registerFormGroup = this.formBuilder.group({
      userName: ["", Validators.required],
      password: ["", Validators.required],
      email: ["", Validators.required],
    });
  }

  onClickRegister(): void {
    if (this.registerFormGroup.valid) {
      const user = new User();
      user.userName = this.registerFormGroup.controls["userName"].value;
      user.password = this.registerFormGroup.controls["password"].value;
      user.email = this.registerFormGroup.controls["email"].value;
      localStorage.setItem("users", JSON.stringify(user));
      const snackRef = this._snackBar.open("Registration Successful!", "Ok", {
        duration: 10000,
      });
      this.router.navigate(["/login"]);
    }
  }
}
