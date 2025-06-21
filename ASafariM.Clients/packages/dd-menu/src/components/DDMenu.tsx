import React, { useState } from "react";
import type { MenuItem } from "../types/menu.types";
import "../styles/dd-menu.css";

interface DDMenuProps {
  items: MenuItem[];
  theme?: "light" | "dark";
  className?: string;
}

export const DDMenu: React.FC<DDMenuProps> = ({
  items,
  theme = "light",
  className = "",
}) => {
  const [openIndexes, setOpenIndexes] = useState<{ [key: string]: boolean }>({});
  const [mobileOpen, setMobileOpen] = useState(false);

  // handle toggling submenu
  const toggleSubMenu = (id: string) =>
    setOpenIndexes((prev) => ({
      ...prev,
      [id]: !prev[id],
    }));

  const renderMenu = (
    menuItems: MenuItem[],
    depth: number = 0
  ): React.ReactNode => (
    <ul
      className="dd-menu__ul"
      style={{
        marginLeft: depth > 0 ? 16 : 0,
        position: depth > 0 ? "absolute" : "relative",
        left: depth > 0 ? "100%" : undefined,
        top: depth > 0 ? 0 : undefined,
        zIndex: 10 + depth,
      }}
    >
      {menuItems.map((item) => {
        const hasChildren = !!item.children?.length;
        return (
          <li
            key={item.id}
            className={[
              "dd-menu__item",
              item.disabled ? "dd-menu__item--disabled" : "",
              hasChildren ? "dd-menu__submenu-anchor" : "",
            ].join(" ")}
            tabIndex={item.disabled ? -1 : 0}
            onClick={(e) => {
              if (item.disabled) {
                e.preventDefault();
                return;
              }
              if (hasChildren) {
                e.stopPropagation();
                toggleSubMenu(item.id);
              } else if (item.onClick) {
                item.onClick();
              }
            }}
            onMouseEnter={() =>
              hasChildren &&
              window.innerWidth > 700 &&
              setOpenIndexes((prev) => ({ ...prev, [item.id]: true }))
            }
            onMouseLeave={() =>
              hasChildren &&
              window.innerWidth > 700 &&
              setOpenIndexes((prev) => ({ ...prev, [item.id]: false }))
            }
          >
            {item.icon && <span style={{ marginRight: 6 }}>{item.icon}</span>}
            {item.link && !hasChildren ? (
              <a
                href={item.link}
                style={{
                  color: "inherit",
                  textDecoration: "none",
                  flex: 1,
                }}
                tabIndex={-1}
              >
                {item.label}
              </a>
            ) : (
              <span style={{ flex: 1 }}>{item.label}</span>
            )}
            {hasChildren && (
              <span className="dd-menu__arrow">
                {openIndexes[item.id] ? "▼" : "▶"}
              </span>
            )}
            {hasChildren && (
              <ul
                className={[
                  "dd-menu__submenu",
                  openIndexes[item.id] ? "dd-menu__submenu--open" : "",
                ].join(" ")}
              >
                {renderMenu(item.children!, depth + 1)}
              </ul>
            )}
          </li>
        );
      })}
    </ul>
  );

  // mobile toggle: hamburger
  return (
    <nav
      className={[
        "dd-menu",
        className,
        mobileOpen ? "" : "dd-menu--closed",
      ].join(" ")}
      data-theme={theme}
      style={{ position: "relative" }}
    >
      <button
        className="dd-menu__mobile-toggle"
        aria-label="Toggle menu"
        onClick={() => setMobileOpen((open) => !open)}
        type="button"
      >
        {mobileOpen ? "✕" : "☰"}
      </button>
      {mobileOpen || window.innerWidth > 700 ? renderMenu(items) : null}
    </nav>
  );
};
