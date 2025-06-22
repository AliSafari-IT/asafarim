import React, { useState, useRef, useEffect } from "react";
import type { MenuItem } from "../types/menu.types";
import "../styles/dd-menu.css";

export type DDMenuVariant = "default" | "minimal" | "navbar" | "sidebar";
export type DDMenuSize = "sm" | "md" | "lg";

export interface DDMenuProps {
  items: MenuItem[];
  theme?: "light" | "dark" | "auto";
  variant?: DDMenuVariant;
  size?: DDMenuSize;
  className?: string;
  style?: React.CSSProperties;
  trigger?: React.ReactNode;
  placement?:
    | "bottom"
    | "bottom-start"
    | "bottom-end"
    | "top"
    | "top-start"
    | "top-end"
    | "right"
    | "left";
  onItemClick?: (item: MenuItem) => void;
  closeOnClick?: boolean;
  disabled?: boolean;
}

const DDMenu = ({
  items,
  theme = "auto",
  variant = "default",
  size = "md",
  className = "",
  style = {},
  trigger,
  placement = "bottom-start",
  onItemClick,
  closeOnClick = true,
  disabled = false,
}: DDMenuProps) => {
  const [isOpen, setIsOpen] = useState(false);
  const [openSubmenus, setOpenSubmenus] = useState<Set<string>>(new Set());
  const menuRef = useRef<HTMLDivElement>(null);
  const buttonTriggerRef = useRef<HTMLButtonElement>(null);
  const customTriggerRef = useRef<HTMLDivElement>(null);

  // Close menu when clicking outside
  useEffect(() => {
    const handleClickOutside = (event: MouseEvent) => {
      const currentTrigger = buttonTriggerRef.current || customTriggerRef.current;
      if (
        menuRef.current &&
        currentTrigger &&
        !menuRef.current.contains(event.target as Node) &&
        !currentTrigger.contains(event.target as Node)
      ) {
        setIsOpen(false);
        setOpenSubmenus(new Set());
      }
    };

    if (isOpen) {
      document.addEventListener("mousedown", handleClickOutside);
      return () =>
        document.removeEventListener("mousedown", handleClickOutside);
    }
  }, [isOpen]);

  // Handle submenu toggle
  const toggleSubmenu = (id: string) => {
    setOpenSubmenus((prev) => {
      const newSet = new Set(prev);
      if (newSet.has(id)) {
        newSet.delete(id);
      } else {
        newSet.add(id);
      }
      return newSet;
    });
  };

  // Handle item click
  const handleItemClick = (item: MenuItem, event: React.MouseEvent) => {
    if (item.disabled) {
      event.preventDefault();
      return;
    }

    if (item.children?.length) {
      event.preventDefault();
      toggleSubmenu(item.id);
      return;
    }

    // Execute item onClick
    if (item.onClick) {
      item.onClick();
    }

    // Execute parent onItemClick
    if (onItemClick) {
      onItemClick(item);
    }

    // Close menu if specified
    if (closeOnClick) {
      setIsOpen(false);
      setOpenSubmenus(new Set());
    }
  };

  // Render menu items recursively
  const renderMenuItems = (
    menuItems: MenuItem[],
    level = 0
  ): React.ReactNode => {
    return menuItems.map((item) => {
      const hasChildren = item.children && item.children.length > 0;
      const isSubmenuOpen = openSubmenus.has(item.id);

      return (
        <li key={item.id} className="dd-menu__item-wrapper">
          <div
            className={`
              dd-menu__item
              ${item.disabled ? "dd-menu__item--disabled" : ""}
              ${item.active ? "dd-menu__item--active" : ""}
              ${hasChildren ? "dd-menu__item--has-children" : ""}
              ${level > 0 ? "dd-menu__item--nested" : ""}
            `.trim()}
            onClick={(e) => handleItemClick(item, e)}
            onMouseEnter={() => {
              if (hasChildren && variant !== "sidebar") {
                setOpenSubmenus((prev) => new Set([...prev, item.id]));
              }
            }}
            onMouseLeave={() => {
              if (hasChildren && variant !== "sidebar") {
                setOpenSubmenus((prev) => {
                  const newSet = new Set(prev);
                  newSet.delete(item.id);
                  return newSet;
                });
              }
            }}
            role="menuitem"
            tabIndex={item.disabled ? -1 : 0}
            aria-disabled={item.disabled}
            aria-expanded={hasChildren ? isSubmenuOpen : undefined}
          >
            {item.icon && (
              <span className="dd-menu__item-icon">
                {typeof item.icon === "string" ? (
                  <span>{item.icon}</span>
                ) : (
                  item.icon
                )}
              </span>
            )}

            <span className="dd-menu__item-label">
              {item.link && !hasChildren ? (
                <a
                  href={item.link}
                  className="dd-menu__item-link"
                  onClick={(e) => e.stopPropagation()}
                >
                  {item.label}
                </a>
              ) : (
                item.label
              )}
            </span>

            {hasChildren && (
              <span className="dd-menu__item-arrow">
                <svg
                  width="16"
                  height="16"
                  viewBox="0 0 16 16"
                  fill="currentColor"
                >
                  <path
                    d="M6 4l4 4-4 4"
                    stroke="currentColor"
                    strokeWidth="1.5"
                    fill="none"
                    strokeLinecap="round"
                    strokeLinejoin="round"
                  />
                </svg>
              </span>
            )}
          </div>

          {hasChildren && (
            <ul
              className={`
                dd-menu__submenu
                dd-menu__submenu--level-${level + 1}
                ${isSubmenuOpen ? "dd-menu__submenu--open" : ""}
              `.trim()}
              role="menu"
            >
              {renderMenuItems(item.children!, level + 1)}
            </ul>
          )}
        </li>
      );
    });
  };
  // Default trigger if none provided
  const defaultTrigger = (
    <button
      ref={buttonTriggerRef}
      className="dd-menu__trigger"
      onClick={() => !disabled && setIsOpen(!isOpen)}
      disabled={disabled}
      aria-expanded={isOpen}
      aria-haspopup="menu"
    >
      <span>Menu</span>
      <svg width="16" height="16" viewBox="0 0 16 16" fill="currentColor">
        <path
          d="M4 6l4 4 4-4"
          stroke="currentColor"
          strokeWidth="1.5"
          fill="none"
          strokeLinecap="round"
          strokeLinejoin="round"
        />
      </svg>
    </button>
  );

  return (
    <div
      className={`
        dd-menu
        dd-menu--${variant}
        dd-menu--${size}
        dd-menu--${theme}
        ${isOpen ? "dd-menu--open" : ""}
        ${disabled ? "dd-menu--disabled" : ""}
        ${className}
      `.trim()}
      style={style}
      data-theme={theme}
    >      {trigger ? (
        <div
          ref={customTriggerRef}
          onClick={() => !disabled && setIsOpen(!isOpen)}
          className="dd-menu__custom-trigger"
        >
          {trigger}
        </div>
      ) : (
        defaultTrigger
      )}

      {isOpen && (
        <div
          ref={menuRef}
          className={`dd-menu__content dd-menu__content--${placement}`}
          role="menu"
          aria-orientation="vertical"
        >
          <ul className="dd-menu__list" role="none">
            {renderMenuItems(items)}
          </ul>
        </div>
      )}
    </div>
  );
};

export { DDMenu };
export default DDMenu;
