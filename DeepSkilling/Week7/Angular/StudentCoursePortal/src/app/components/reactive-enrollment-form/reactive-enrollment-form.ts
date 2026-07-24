import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  ReactiveFormsModule,
  FormBuilder,
  Validators,
  FormGroup
} from '@angular/forms';

@Component({
  selector: 'app-reactive-enrollment-form',
  standalone: true,
  imports: [
    CommonModule,
    ReactiveFormsModule
  ],
  templateUrl: './reactive-enrollment-form.html',
  styleUrl: './reactive-enrollment-form.css'
})
export class ReactiveEnrollmentForm {

  enrollmentForm: FormGroup;

  constructor(private fb: FormBuilder) {

    this.enrollmentForm = this.fb.group({

      studentName: [
        '',
        [
          Validators.required,
          Validators.minLength(3)
        ]
      ],

      email: [
        '',
        [
          Validators.required,
          Validators.email
        ]
      ],

      courseId: [
        '',
        Validators.required
      ],

      semester: [
        'Odd'
      ],

      agree: [
        false,
        Validators.requiredTrue
      ]

    });

  }

  onSubmit(): void {

    if (this.enrollmentForm.valid) {

      console.log(this.enrollmentForm.value);

    } else {

      this.enrollmentForm.markAllAsTouched();

    }

  }

}