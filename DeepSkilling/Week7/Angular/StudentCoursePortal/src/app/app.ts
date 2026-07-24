import { Component, signal } from '@angular/core';

import { Header } from './components/header/header';
import { Footer } from './components/footer/footer';
import { Home } from './components/home/home';
import { CourseList } from './components/course-list/course-list';
import { CourseDetail } from './components/course-detail/course-detail';
import { StudentProfile } from './components/student-profile/student-profile';
import { EnrollmentForm } from './components/enrollment-form/enrollment-form';
import { ReactiveEnrollmentForm } from './components/reactive-enrollment-form/reactive-enrollment-form';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    Header,
    Footer,
    Home,
    CourseList,
    CourseDetail,
    StudentProfile,
    EnrollmentForm,
    ReactiveEnrollmentForm
  ],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('StudentCoursePortal');
}