// E:\asm-fs\apps\frontends\asafarim-client\src\hooks\useNavItems.tsx
import { getAllMdFiles } from "../utils/mdFilesUtils";
import {
  Teaching24Regular as IconTeaching,
  ProjectionScreenText24Regular as IconProject,
  PhoneVibrate24Regular as IconContact,
  Board24Regular as IconDashboard,
  Home24Regular as IconHome,
  Person24Regular as IconProfile,
  Accessibility24Regular as IconAccount,
  SignOut24Regular as IconLogout
} from '@fluentui/react-icons';
import useAuth from "./useAuth";
import {logger} from "../utils/logger";
import React from "react";
import { IMenuItem } from "../interfaces/IMenuItem";

const logreg: IMenuItem[] = [
  {
    id: 'login',
    name: 'login',
    title: 'Login',
    label: 'Login',
    to: '/login',
    icon: <IconProfile />,
  },
  {
    id: 'register',
    name: 'register',
    title: 'Register',
    label: 'Register',
    to: '/register',
    icon: <IconProfile />,
  },
];

const emailBody = encodeURIComponent(`To ASafariM Team,

Hello,

[Your subject here]

[Add your message/information here]

---
[Your Name]
[Your Contact Information]`);
const emailSubject = 'Contact ASafariM';
const emailTo = 'ASafariM <ali@asafarim.com>';
const emailLink = `mailto:${emailTo}?subject=${encodeURIComponent(emailSubject)}&body=${emailBody}`;
// Home Dropdown
const homeDD: IMenuItem = {
  id: 'home',
  name: 'home',
  title: 'Home',
  to: '#',
  icon: <IconHome />,
  label: 'Home',
  isForNavbar: true,
  subMenu: [
    {
      id: 'brand-asafarim',
      name: 'brand-asafarim',
      title: 'ASafariM',
      to: '/',
      className: 'asafarim-brand',
      description: 'ASafariM is a free and open source project for learning web development.',
      icon: <IconTeaching />,
      label: 'ASafariM',
    },
    {
      id: 'about',
      name: 'about',
      title: 'About',
      to: '/about-asafarim',
      icon: <IconProject />,
      label: 'About',
      description: 'ASafariM is a free and open source project for learning web development.',
      className: '',
    },
    {
      id: 'contact',
      name: 'contact',
      title: 'Contact',
      icon: <IconContact />,
      label: 'Contact',
      description: 'Contact ASafariM for any questions or feedback.',
      subMenu: [
        {
          id: 'asafarim-gg-site',
          name: 'asafarim-gg-site',
          title: 'ASafariM Google Site',
          to: 'https://sites.google.com/view/asafarim-it/',
          target: '_blank',
          icon: <IconContact />,
          label: 'ASafariM Google Site',
          description: 'Visit ASafariM Google Site.',
        },
        {
          id: 'contact-us',
          name: 'contact-us',
          title: 'Contact Us',
          to: '/contact',
          icon: <IconContact />,
          label: 'Contact Us',
          description: 'Contact ASafariM for any questions or feedback.',
        },
        {
          id: 'email',
          name: 'email',
          title: 'Email',
          to: emailLink,
          className: '',
          icon: <IconContact />,
          label: 'Email',
        }
      ],
    },
  ],
};

// Dashboard Dropdown
const dashboardDD: IMenuItem = {
  id: 'dashboard',
  name: 'dashboard',
  title: 'Dashboard',
  label: 'Dashboard',
  isForNavbar: true,
  to: '#',
  icon: <IconDashboard />,
  subMenu: [
    {
      id: 'system-health',
      name: 'system-health',
      title: 'System Health Status',
      label: 'System Health Status',
      to: '/system-health',
      icon: <IconDashboard />,
      style: {},
      className: 'system-health'
    },
    {
      id: 'user-dashboard',
      name: 'user-dashboard',
      title: 'Dashboard',
      label: 'Dashboard',
      to: '/dashboard',
      icon: <IconDashboard />,
      style: {},
      className: 'user-dashboard'
    },
    {
      id: 'projects',
      name: 'projects',
      title: 'Projects',
      label: 'Projects',
      to: '/projects',
      icon: <IconProject />,
      style: {},
      className: 'projects'
    },
    {
      id: 'users',
      name: 'users',
      title: 'Users',
      label: 'Users',
      to: '/users',
      icon: <IconProfile />,
    },
  ],
};


const useNavItems = () => {
  const mdFiles = getAllMdFiles();
  const {  authenticated, token } = useAuth();
  logger.debug("useNavItems: authenticated is:", authenticated);

  // User Account Dropdown - only this needs to change based on auth state
  const userAccountDD: IMenuItem = {
    id: 'user-account',
    name: 'user-account',
    isForNavbar: true,
    title: 'Account',
    to: '#',
    icon: <IconAccount />,
    label: 'Account',
    subMenu: (authenticated && token)
      ? [
        {
          id: 'logout',
          name: 'logout',
          title: 'Logout',
          label: 'Logout',
          to: '/logout',
          icon: <IconLogout />,
        }
      ]
      : [...logreg]
  };
  // Sort Change Logs by Date
  const sortedChangeLogs = {
    ...mdFiles.changelogs,
    subMenu: [...(mdFiles.changelogs.subMenu || [])].sort((a, b) => {
      const dateA = new Date(a.updatedAt || a.createdAt || 0).getTime();
      const dateB = new Date(b.updatedAt || b.createdAt || 0).getTime();
      return dateB - dateA; // Sort descending (newest first)
    }),
  };

  // Directly return the computed nav items
  return [
    homeDD,
    { ...mdFiles.techDocs, isForNavbar: true },
    { ...mdFiles.legalDocs, isForNavbar: true },
    { ...sortedChangeLogs, isForNavbar: false },
    { ...mdFiles.essentialInsights, isForNavbar: true },
    dashboardDD,
    userAccountDD
  ];
};

export default useNavItems;
