# Technische Toelichting – ASafariM Project

Hieronder geef ik een overzicht van de belangrijkste technische elementen van mijn full-stack project **ASafariM**. 
Dit project heb ik volledig zelf ontwikkeld met focus op schaalbaarheid, veiligheid en onderhoudbaarheid, en het toont mijn capaciteiten als .NET- en React-ontwikkelaar.

## 1. ASP.NET Core 9.0 met Clean Architecture
Het project is opgebouwd met **.NET 9.0** (de nieuwste STS-release) en volgt **Clean Architecture** principes. 
De oplossing bestaat uit vier duidelijke lagen: `Domain`, `Application`, `Infrastructure` en `Api`. 
Deze structuur maakt het project overzichtelijk, schaalbaar en testbaar.

## 2. MySQL als relationele database met Entity Framework Core
Voor de datalaag gebruik ik **EF Core** met **MySQL**. 
De database bevat onder andere gebruikers, voorkeuren en projecten, en is opgezet via migrations en seeddata. 
De `DbContext` is geconfigureerd met `RetryOnFailure` voor extra stabiliteit.

## 3. JWT Authenticatie via SecureGate
Ik heb een eigen JWT-gebaseerd authenticatiesysteem ontwikkeld onder de naam **SecureGate**. 
Gebruikers kunnen zich registreren en inloggen, en toegang wordt beheerd via policies en rolgebaseerde autorisatie.

## 4. React + TypeScript Frontend (SPA)
De frontend is gebouwd met **React** en **TypeScript**, gestyled met **TailwindCSS** en SCSS. 
De gebruikersinterface is een Single Page Application met functionaliteiten voor gebruikersbeheer, projecten, blogposts en markdown-documentatie, inclusief ondersteuning voor donker/licht thema’s.

## 5. Geautomatiseerd testen met MSTest
Voor het testen van de backend gebruik ik **MSTest** als testframework. 
De tests zijn ondergebracht in een apart testproject en richten zich op de belangrijkste functionaliteiten. 
Daarnaast maak ik gebruik van **coverlet.collector** om de test coverage te meten. 
Dit zorgt ervoor dat de kwaliteit van de code bewaakt wordt en eventuele fouten vroegtijdig worden opgespoord.

## 6. API-documentatie en monitoring
De Web API is voorzien van **Swagger UI** voor interactieve documentatie en testen. 
Daarnaast zijn er **ASP.NET Health Check** endpoints geïntegreerd (zoals `/health`) om de beschikbaarheid van de backend te monitoren.

## 7. Productie-deployment op Linux VPS
Het project draait live op een **Hostinger VPS** (asafarim.com). 
Ik heb **NGINX** geconfigureerd als reverse proxy, en de backend draait als een **systemd-service** (`dashboardapi.service`). 
De frontend is gedeployed naar de juiste `public_html`-map voor productiegebruik.

## ToDo features
### Geautomatiseerde deployment
TODO: Voor het automatiseren van de deployment gebruik ik **GitHub Actions**. 
De workflow draait elke keer dat code wordt geüpload naar de `main`-branch en draait de build en deploy processen.

[
    current deployment process is triggered manually, but after starting the deployment process, the process is automated as it's programmed in bash shell script `publish.sh`.
]

### Geautomatiseerde testen
De applicatie bevat een uitgebreide testsuite die zowel handmatig als automatisch kan worden uitgevoerd. Voor het automatiseren van de testen gebruik ik een combinatie van shell scripts en package.json commando's.

#### Testautomatisering
De tests kunnen op de volgende manieren worden uitgevoerd:

1. **Handmatig via yarn commando's**:
   ```bash
   # Backend tests uitvoeren
   yarn test:backend
   
   # Backend tests in watch mode
   yarn tbw
   
   # Geautomatiseerd testscript uitvoeren
   yarn test:script
   ```

2. **Via shell scripts**:
   - `./scripts/test-scripts/test.sh`

Het testproces is volledig geautomatiseerd en genereert testresultaten in TRX-formaat die kunnen worden bekeken in Visual Studio of andere testrapportage tools.

#### Integratie met deployment
De testresultaten worden automatisch gecontroleerd voordat een deployment wordt uitgevoerd. Hiervoor zijn de volgende mechanismen geïmplementeerd:

1. **Verificatie van testresultaten**:
   - Controle op gefaalde tests in het TRX-bestand
   - Gedetailleerde rapportage van testresultaten
   - Blokkeren van deployment wanneer tests falen

2. **Deployment conditionele commando's**:
   ```bash
   # Deployment alleen uitvoeren als alle tests slagen
   yarn deploy:if-tests-pass
   ```

3. **Integratie in publish.sh**:
   Het deployment script bevat nu een `run_tests_and_verify` functie die:
   - Tests uitvoert vóór deployment
   - De deployment stopt als er tests falen
   - Gedetailleerde logging biedt van het testproces

Deze integratie zorgt ervoor dat alleen code die voldoet aan de kwaliteitseisen in productie wordt geplaatst.

#### Toekomstige CI/CD integratie
In de toekomst zal het testproces worden geïntegreerd in een CI/CD pipeline met GitHub Actions. De workflow zal elke keer dat code wordt geüpload naar de `main`-branch draaien en de build- en testprocessen automatiseren.
