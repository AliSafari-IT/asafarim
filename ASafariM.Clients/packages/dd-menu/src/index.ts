export { DDMenu, default as DDMenuDefault } from "./components/DDMenu";
export * from "./types/menu.types";
export { DDMenu as default } from "./components/DDMenu";

// Re-export types for easier consumption
export type { 
  DDMenuVariant, 
  DDMenuSize, 
} from "./components/DDMenu";

// Also export the props interface
export type { DDMenuProps } from "./components/DDMenu";
