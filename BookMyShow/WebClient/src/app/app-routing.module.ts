import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { SearchComponent } from './search/search.component';

const routes: Routes = [
  { path: '', redirectTo: 'explore', pathMatch: 'full'},
  { path: 'user', children: [
    {path: 'customer', loadChildren: () => import('./customer/customer.module').then(c => c.CustomerModule)}
  ]},
  { path: 'explore', children: [
    {path: '', redirectTo: 'home', pathMatch: 'full'},
    {path: 'search', component: SearchComponent},
    {path: 'home', component: HomeComponent},
    {path: ':location', children: [
      {path: 'movies', loadChildren: () => import('./movies/movies.module').then(m => m.MoviesModule)}
    ]}    
  ]},
  { path: '404', component: PageNotFoundComponent},
  { path: '**', redirectTo: '404'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {useHash: true})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
