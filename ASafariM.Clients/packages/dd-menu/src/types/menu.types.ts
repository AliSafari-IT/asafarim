import React from "react";

export interface MenuItem {
  id: string;
  label: string;
  link?: string;
  onClick?: () => void;
  icon?: React.ReactNode;
  disabled?: boolean;
  children?: MenuItem[];
}
