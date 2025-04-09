---
sidebar_position: 2
title: "Nx Workspaces"
---

Nx workspaces are highly flexible and can be organized in different ways depending on your project's needs. Here are the main types of Nx workspace structures:

### **1. Monorepo Workspace**

- **Description:** A single repository that contains multiple projects, such as applications and libraries.
- **Use Case:** Ideal for teams working on multiple related projects that share code and dependencies.
- **Structure Example:**
  ```
  apps/
    app1/
    app2/
  libs/
    shared/
    ui/
    data-access/
  ```
- **Advantages:** Centralized management, code reuse, and consistent tooling.

---

### **2. Modulith Workspace**

- **Description:** A hybrid between a monolith and microservices. It maintains a single deployable unit but organizes code into modular libraries.
- **Use Case:** Suitable for projects that need modularity without the complexity of microservices.
- **Structure Example:**
  ```
  apps/
    app/
  libs/
    feature/
    ui/
    util/
  ```
- **Advantages:** Easier to maintain than microservices while still benefiting from modularity.

---

### **3. Microservices Workspace**

- **Description:** A workspace designed for microservices architecture, where each service is treated as an independent project.
- **Use Case:** Best for large-scale systems requiring independent deployment and scaling.
- **Structure Example:**
  ```
  apps/
    service1/
    service2/
  libs/
    shared/
  ```
- **Advantages:** Scalability and independent development of services.

---

### **4. Nested Grouping Workspace**

- **Description:** Projects are grouped by scope or domain within nested folders.
- **Use Case:** Useful for organizing projects by functionality or business domains.
- **Structure Example:**
  ```
  apps/
    booking/
      feature-shell/
    check-in/
      feature-shell/
  libs/
    shared/
      data-access/
      feature-seatmap/
  ```
- **Advantages:** Clear organization by domain, reducing navigation complexity.

---

### **5. Shared Libraries Workspace**

- **Description:** Focuses on creating reusable libraries that can be shared across multiple applications.
- **Use Case:** Ideal for teams building components, utilities, or data-access layers used across projects.
- **Structure Example:**
  ```
  libs/
    ui-buttons/
    util-testing/
    data-access-seatmap/
  ```
- **Advantages:** Promotes code reuse and consistency.

---

Each workspace type can be tailored further based on your project's requirements. You can learn more about Nx workspace structures [here](https://nx.dev/blog/virtuous-cycle-of-workspace-structure) or explore dependency rules for libraries [here](https://nx.dev/concepts/decisions/project-dependency-rules) 🚀.
