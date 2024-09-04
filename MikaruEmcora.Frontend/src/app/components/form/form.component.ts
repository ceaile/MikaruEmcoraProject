import { Component, Input, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrl: './form.component.css'
})
export class FormComponent {
  @Input() formGroup!: FormGroup;
  @Output() formSubmit = new EventEmitter<void>(); //esto debe llamar a un service para autenticar,etc

  onSubmit(): void {
    if (this.formGroup.valid) {
      this.formSubmit.emit(); // Emite el evento de envío si el formulario es válido
    }
  }
}
