# React-DotNet-Vite-TailwindCSS Setup Guide

This guide will help you create a full-stack application using React with TypeScript, ASP.NET Core, TailwindCSS, and Vite. The app will display a home page with the sitemap.

## Prerequisites

- Node.js (v16 or higher)
- .NET 7 SDK or higher
- Yarn or npm (Yarn preferred)
- Visual Studio Code (VS Code)
- Vite
- TailwindCSS

## Step 1: Set Up the .NET Core Backend

1. Open a terminal and create a new .NET Web API project:

   ```bash
   dotnet new webapi -n Dashboard.Server
   ```

2. Navigate to the newly created `Dashboard.Server` folder:

   ```bash
   cd Dashboard.Server
   ```

3. Set up the project structure by creating a folder for the client app inside the server folder:

   ```bash
   mkdir ../Dashboard.Client
   ```

4. Open the `launchSettings.json` file inside `Properties` and make sure the `applicationUrl` is set to `https://localhost:5001` for HTTPS or `http://localhost:5000` for HTTP.

## Step 2: Set Up the React Frontend with Vite

1. Navigate to the client folder:

   ```bash
   cd ../Dashboard.Client
   ```

2. Create a React app with Vite using TypeScript:

   ```bash
   yarn create vite
   ```

   Select the following options:
   - Project name: `dashboard-client`
   - Framework: `React`
   - Variant: `TypeScript`

3. Install required dependencies:

   ```bash
   cd dashboard-client
   yarn
   ```

4. Install TailwindCSS:

   ```bash
   yarn add -D tailwindcss postcss autoprefixer
   npx tailwindcss init -p
   ```

5. Configure `tailwind.config.js` by adding the following content:

   ```js
   module.exports = {
     content: [
       "./index.html",
       "./src/**/*.{js,ts,jsx,tsx}",
     ],
     theme: {
       extend: {},
     },
     plugins: [],
   }
   ```

6. Add Tailwind directives to `src/index.css`:

   ```css
   @tailwind base;
   @tailwind components;
   @tailwind utilities;
   ```

7. Update `vite.config.ts` to allow development with the backend by adding proxy settings:

   ```ts
   import { defineConfig } from 'vite'
   import react from '@vitejs/plugin-react'

   export default defineConfig({
     plugins: [react()],
     server: {
       proxy: {
         '/api': 'http://localhost:5000', // Proxy API requests to .NET Core server
       },
     },
   })
   ```

## Step 3: Connect the React App to the .NET API

1. In the `.NET` project (`Dashboard.Server`), open `Startup.cs` (or `Program.cs` in newer .NET versions), and add CORS configuration to allow communication with the frontend:

   ```csharp
   var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
   
   builder.Services.AddCors(options =>
   {
       options.AddPolicy(name: MyAllowSpecificOrigins,
                         policy  =>
                         {
                             policy.WithOrigins("http://localhost:5173") // Vite runs on port 5173
                                   .AllowAnyHeader()
                                   .AllowAnyMethod();
                         });
   });
   ```

2. Enable CORS in the `app.UseCors` line before `UseAuthorization`:

   ```csharp
   app.UseCors(MyAllowSpecificOrigins);
   ```

3. Set up a simple API endpoint in the .NET project to return the sitemap. Open `Controllers/WeatherForecastController.cs` and add a new endpoint:

   ```csharp
   [Route("api/[controller]")]
   [ApiController]
   public class SitemapController : ControllerBase
   {
       [HttpGet]
       public IActionResult GetSitemap()
       {
           var sitemap = new List<string> { "Home", "About", "Contact", "Dashboard" };
           return Ok(sitemap);
       }
   }
   ```

## Step 4: Create the Home Page in React

1. Inside the React project (`Dashboard.Client`), create a new component named `Sitemap.tsx` inside the `src` folder:

   ```tsx
   import React, { useEffect, useState } from 'react'
   import axios from 'axios'

   const Sitemap = () => {
     const [sitemap, setSitemap] = useState<string[]>([])

     useEffect(() => {
       axios.get('/api/sitemap')
         .then(response => setSitemap(response.data))
         .catch(error => console.error(error))
     }, [])

     return (
       <div className="p-8">
         <h1 className="text-2xl font-bold mb-4">Sitemap</h1>
         <ul>
           {sitemap.map((page, index) => (
             <li key={index} className="text-lg">
               {page}
             </li>
           ))}
         </ul>
       </div>
     )
   }

   export default Sitemap
   ```

2. Update `App.tsx` to display the sitemap:

   ```tsx
   import React from 'react'
   import './App.css'
   import Sitemap from './Sitemap'

   function App() {
     return (
       <div className="App">
         <Sitemap />
       </div>
     )
   }

   export default App
   ```

## Step 5: Run the Application

1. Run the backend (in the `Dashboard.Server` folder):

   ```bash
   dotnet run
   ```

2. In a separate terminal, run the frontend (in the `Dashboard.Client/dashboard-client` folder):

   ```bash
   yarn dev
   ```

3. Open your browser and navigate to `http://localhost:5173`. You should see a home page displaying the sitemap.

## Conclusion

You have successfully set up a full-stack React TypeScript application with Vite, ASP.NET Core, and TailwindCSS. The app displays a home page that retrieves and shows the sitemap from the backend API.
