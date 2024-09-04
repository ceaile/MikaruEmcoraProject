import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-contact-me',
  templateUrl: './contact-me.component.html',
  styleUrls: ['./contact-me.component.css']
})
export class ContactMeComponent implements OnInit {
  contactForm!: FormGroup;

  constructor(private fb: FormBuilder, private http: HttpClient) { }

  ngOnInit(): void {
    this.contactForm = this.fb.group({
      name: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      subject: ['', Validators.required],
      message: ['', Validators.required]
    });
  }

  onSubmit() {
    if (this.contactForm.valid) {
      this.http.post('https://your-backend-url/api/contact', this.contactForm.value) //for now hardcoded, might do it cleaner later
        .subscribe(response => {
          console.log('Form sent correctly', response);
          // Aquí puedes agregar la lógica para mostrar una página de confirmación
        }, error => {
          console.error('Error in sending email', error);
        });
    }
  }
}
