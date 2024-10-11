import React, { useEffect, useState } from 'react';
import { IconButton, Dropdown, IDropdownOption } from '@fluentui/react';
import sitemapService from '../api/sitemapService';
import '../styles/sitemap-page.css';

const SitemapPage = () => {
  const [sitemapData, setSitemapData] = useState<any[]>([]);
  const [loading, setLoading] = useState<boolean>(true);

  useEffect(() => {
    // Fetch sitemap data from API
    const fetchData = async () => {
      try {
        const data = await sitemapService.getSitemap();
        setSitemapData(data);
        setLoading(false);
      } catch (error) {
        console.error('Error fetching sitemap:', error);
      }
    };
    fetchData();
  }, []);

  if (loading) {
    return <p>Loading...</p>;
  }

  // Handle actions (CRUD)
  const handleEdit = (id: string) => {
    console.log('Edit sitemap ID:', id);
    // Add logic to edit a sitemap item
  };

  const handleDelete = (id: string) => {
    console.log('Delete sitemap ID:', id);
    // Add logic to delete a sitemap item
  };

  const handleCreate = () => {
    console.log('Create new sitemap');
    // Add logic to create a new sitemap item
  };

  const dropdownOptions: IDropdownOption[] = [
    { key: 'edit', text: 'Edit' },
    { key: 'delete', text: 'Delete' },
  ];

  const handleDropdownChange = (itemId: string, option: IDropdownOption) => {
    if (option.key === 'edit') {
      handleEdit(itemId);
    } else if (option.key === 'delete') {
      handleDelete(itemId);
    }
  };

  return (
    <div className="sitemap-page">
      <h1>Sitemap</h1>
      <table className="w-full border-collapse table-auto">
        <thead>
          <tr className="border-b">
            <th>ID</th>
            <th>Page Name</th>
            <th>Description</th>
            <th>Slug</th>
            <th>Access By Role</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {sitemapData.map((item) => (
            <tr key={item.id} className="border-b">
              <td>{item.id}</td>
              <td>{item.pageName}</td>
              <td>{item.description}</td>
              <td>{item.slug}</td>
              <td>{item.accessByRole}</td>
              <td>
                <Dropdown
                  placeholder="Actions"
                  options={dropdownOptions}
                  onChange={(e, option) => handleDropdownChange(item.id, option!)}
                  ariaLabel="Actions Dropdown"
                />
              </td>
            </tr>
          ))}
        </tbody>
      </table>

      <div className="mt-4">
        <IconButton
          iconProps={{ iconName: 'Add' }}
          title="Create"
          ariaLabel="Create"
          onClick={handleCreate}
        />
      </div>
    </div>
  );
};

export default SitemapPage;
