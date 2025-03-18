# ASafariM Movies with ASP.NET Core and Angular

With **ASP.NET Core**, we can develop Web APIs using C#.  
With **Angular**, we can create modern web applications without too many headaches.

In this course, we will use both tools to create a project. We will make an application with a database, user system, back-end, and UI, where you will put into practice the concepts learned in the course.

We will go step by step, both in the development of the front-end with Angular and the back-end in ASP.NET Core. You can take this course without having too much knowledge of both technologies. In fact, I will teach you the basics of these technologies throughout the course.

At the end, we will publish our Angular application and our ASP.NET Core application.

## Topics
- Developing Web APIs with ASP.NET Core  
- Creating a Database in SQL Server using Entity Framework Core  
- User system with Json Web Tokens (JWT)  
- Developing a single-page application (SPA) with Angular  
- Creating reactive forms in Angular  
- Making HTTP requests from Angular to ASP.NET Core  
- Using Angular Material components  
- Using maps with Leaflet  
- Saving spatial data in a database with NetTopologySuite  
- Allowing users to upload images to be saved in Azure Storage or locally  
- Automatic tests in .NET and Angular  

## Learn 
- Build Web APIs with .NET Core  
- Develop Single-Page Apps with Angular  
- Use Entity Framework Core to work with databases  
- Create register and login functionality  
- Deploy .NET Core and Angular apps  

## Sample Code Snippets

### ASP.NET Core Web API Example
```csharp
[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public MoviesController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
    {
        return await _context.Movies.ToListAsync();
    }
}
```

### Angular Component Example
```typescript
@Component({
  selector: 'app-movies-list',
  templateUrl: './movies-list.component.html',
  styleUrls: ['./movies-list.component.css']
})
export class MoviesListComponent implements OnInit {
  movies: Movie[] = [];

  constructor(private movieService: MovieService) { }

  ngOnInit(): void {
    this.loadMovies();
  }

  loadMovies(): void {
    this.movieService.getMovies().subscribe(
      (data) => this.movies = data,
      (error) => console.error(error)
    );
  }
}
```

### Angular Service Example
```typescript
@Injectable({
  providedIn: 'root'
})
export class MovieService {
  private apiUrl = 'https://localhost:5001/api/movies';

  constructor(private http: HttpClient) { }

  getMovies(): Observable<Movie[]> {
    return this.http.get<Movie[]>(this.apiUrl);
  }
}
```

### Angular Template Example
```html
<div class="movies-container">
    <div *ngFor="let movie of movies">
        <h2>{{movie.title}}</h2>
        <p>{{movie.releaseDate}}</p>
        <p>{{movie.price}}</p>
    </div>
</div>
```

### Angular Material Example
```typescript
@Component({
  selector: 'app-movies-list',
  templateUrl: './movies-list.component.html',
  styleUrls: ['./movies-list.component.css']
})
export class MoviesListComponent implements OnInit {
  movies: Movie[] = [];

  constructor(private movieService: MovieService) { }

  ngOnInit(): void {
    this.loadMovies();
  }

  loadMovies(): void {
    this.movieService.getMovies().subscribe(
      (data) => this.movies = data,
      (error) => console.error(error)
    );
  }
}
```

### Angular Material Template Example
```html
<div class="movies-container">
    <div *ngFor="let movie of movies">
        <h2>{{movie.title}}</h2>
        <p>{{movie.releaseDate}}</p>
        <p>{{movie.price}}</p>
    </div>
</div>
```

# Entity Framework Core Configuration
```csharp
public class ApplicationDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Title).IsRequired().HasMaxLength(100);
            entity.Property(e => e.ReleaseDate).IsRequired();
            entity.Property(e => e.Price).IsRequired();
            entity.Property(e => e.Poster).HasMaxLength(256);
        });
    }
}
```

### Entity Framework Core Movie Model
```csharp
public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime ReleaseDate { get; set; }
}

public class ApplicationDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
}
```

Upon completing this project, you will have sufficient knowledge to face challenges involving ASP.NET Core and Angular applications. You will be able to:

- Design and implement RESTful APIs using ASP.NET Core  
- Build interactive and responsive user interfaces with Angular  
- Manage application state and handle asynchronous operations  
- Implement authentication and authorization mechanisms  
- Work with databases using Entity Framework Core  
- Deploy and maintain full-stack applications  