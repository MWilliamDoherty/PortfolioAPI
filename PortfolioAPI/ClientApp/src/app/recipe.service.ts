import { Injectable } from '@angular/core';
import { retry, catchError } from 'rxjs/operators';
import { Observable, throwError } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})

export class Recipe {
  Id: number | undefined;
  Name: string | undefined;
  Steps: Step[] | undefined;
}

export class Step {
  Id: number | undefined;
  NumberInList: number | undefined;
  ActionId: number | undefined;
  RecipeId: number | undefined;
  Notes: string | undefined;
  Action: Action | undefined;
  Measurements: Measurement[] | undefined;
}

export class Measurement {
  Id: number | undefined;
  IngredientId: number | undefined;
  MeasurementTypeId: number | undefined;
  Quantity: number | undefined;
  Ingredient: Ingredient | undefined;
}

export class Ingredient {
  Id: number | undefined;
  Name: string | undefined;
}

export class Action {
  Id: number | undefined;
  Name: string | undefined;
}

@Injectable()
export class RecipeService {
  endpoint = 'https://localhost:44396';
  constructor(private http: HttpClient) { }

  getRecipeNames() {
    return this.http.get<Recipe>(this.endpoint);
  }
}
