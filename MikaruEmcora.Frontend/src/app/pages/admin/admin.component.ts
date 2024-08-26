import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrl: './admin.component.css'
})
export class AdminComponent implements OnInit {
  constructor(private fb: FormBuilder) { }
  

  adminForm!: FormGroup;



  ngOnInit(): void {
    this.adminForm = this.fb.group({
      //validations
    });
  }

  onSubmit(): void {
    if (this.adminForm.valid) {
      const portfolioData = this.adminForm.value;
      console.log('portfolio crud data:', portfolioData);
      // logic to server
    }
  }
  
}
