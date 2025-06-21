# A recursive dropdown menu component for React (TypeScript)
A recursive dropdown menu component for React (TypeScript), fully themeable (light/dark), pure CSS, and mobile-friendly.

## 1. Package Layout

```
@asafarim/dd-menu/
├── src/
│   ├── components/
│   │   └── DDMenu.tsx
│   ├── types/
│   │   └── menu.types.ts
│   ├── styles/
│   │   └── dd-menu.css
│   └── index.ts
├── package.json
├── tsconfig.json
├── README.md
```

---

## 2. package name
Package name is:  ***`@asafarim/dd-menu`***

### Install

```sh
yarn add @asafarim/dd-menu
# or
npm install @asafarim/dd-menu
````

## Usage

```tsx
import { DDMenu, MenuItem } from "@asafarim/dd-menu";
import "@asafarim/dd-menu/dist/dd-menu.css";

const menuItems: MenuItem[] = [
  { id: "1", label: "Home", link: "/" },
  {
    id: "2",
    label: "Products",
    children: [
      { id: "2-1", label: "Phones", link: "/phones" },
      { id: "2-2", label: "Laptops", link: "/laptops" },
    ],
  },
  { id: "3", label: "About", link: "/about" },
];

export default function Navbar() {
  return <DDMenu items={menuItems} theme="dark" />;
}
```

### Features

* Recursive menu nesting (unlimited)
* Pure CSS, zero dependencies
* Theme support (light/dark/your own via CSS vars)
* Mobile friendly: collapses to a hamburger on mobile
* Supports icons, disabled, and links

### License

MIT
