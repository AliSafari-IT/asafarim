import React from "react";
import ElegantDropdownShowcase from "./ElegantDropdownShowcase";
import MinimalDDMenuShowcase from "./MinimalDDMenuShowcase";
import ProfessionalDropdownShowcase from "./ProfessionalDropdownShowcase";
import SearchableDropdown from "./SearchableDropdown";
import "../styles/enhanced-dropdown.css";
import '../styles/professional-dropdown.css';

const TestComponent: React.FC = () => {
  return (
    <div style={{ padding: '20px', maxWidth: '1200px', margin: '0 auto' }}>
      <h1 style={{ 
        marginBottom: '30px', 
        textAlign: 'center',
        fontSize: '32px',
        fontWeight: 'bold',
        color: '#1e293b'
      }}>Dropdown Menu Showcase</h1>
      
      <div style={{ marginBottom: '60px' }}>
        <h2 style={{ 
          marginBottom: '20px', 
          fontSize: '24px',
          fontWeight: '600',
          color: '#334155',
          borderBottom: '2px solid #e2e8f0',
          paddingBottom: '10px'
        }}>Professional Dropdown</h2>
        <ProfessionalDropdownShowcase />
      </div>
      
      <div style={{ marginBottom: '60px' }}>
        <h2 style={{ 
          marginBottom: '20px', 
          fontSize: '24px',
          fontWeight: '600',
          color: '#334155',
          borderBottom: '2px solid #e2e8f0',
          paddingBottom: '10px'
        }}>Searchable Dropdown</h2>
        <SearchableDropdown />
      </div>
      
      <div style={{ marginBottom: '60px' }}>
        <h2 style={{ 
          marginBottom: '20px', 
          fontSize: '24px',
          fontWeight: '600',
          color: '#334155',
          borderBottom: '2px solid #e2e8f0',
          paddingBottom: '10px'
        }}>Elegant Dropdown</h2>
        <ElegantDropdownShowcase />
      </div>
      
      <div>
        <h2 style={{ 
          marginBottom: '20px', 
          fontSize: '24px',
          fontWeight: '600',
          color: '#334155',
          borderBottom: '2px solid #e2e8f0',
          paddingBottom: '10px'
        }}>Minimal Dropdown</h2>
        <MinimalDDMenuShowcase />
      </div>
    </div>
  );
};

export default TestComponent;
