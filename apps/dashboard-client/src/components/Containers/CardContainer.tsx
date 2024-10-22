// src/components/CardContainer.tsx
import React, { useState } from 'react';

import {
  Button,
  FluentProvider,
  makeStyles,
  Text,
  webDarkTheme,
  webLightTheme,
} from '@fluentui/react-components';
import { DashCard } from './DashCard';
import { TextField } from '@fluentui/react';
import { useTheme } from '../../hooks/useTheme';
import { ArrowLeft24Regular, ArrowRight24Regular } from '@fluentui/react-icons';

const useStyles = makeStyles({
  container: {
    padding: '20px',
    display: 'flex',
    flexDirection: 'column',
    alignItems: 'center',
  },
  cardsWrapper: {
    display: 'flex',
    flexWrap: 'wrap',
    justifyContent: 'center',
    gap: '16px',
    marginBottom: '20px',
  },
  pagination: {
    display: 'flex',
    alignItems: 'center',
    gap: '10px',
  },
});

const CardContainer: React.FC = () => {
  const classes = useStyles();
  const totalCards = 9; // Adjust as needed
  const cardsPerPage = 3;
  const totalPages = Math.ceil(totalCards / cardsPerPage);

  const [currentPage, setCurrentPage] = useState<number>(1);
  const [inputPage, setInputPage] = useState<string>('');
  const theme = useTheme().theme == 'dark' ? webDarkTheme : webLightTheme;


  // Generate placeholder cards
  const cards = Array.from({ length: totalCards }, (_, index) => (
    <DashCard
      key={index}
      title={`Card ${index + 1}`}
      content={`Content for card ${index + 1}`}
      description={`Description for card ${index + 1}`}
      imgPath="avatar_elvia.svg"
      imgAlt="Elvia Avatar"
    />
  ));

  // Determine the cards to display on the current page
  const startIndex = (currentPage - 1) * cardsPerPage;
  const currentCards = cards.slice(startIndex, startIndex + cardsPerPage);

  const goToNextPage = () => {
    setCurrentPage((prev) => Math.min(prev + 1, totalPages));
  };

  const goToPreviousPage = () => {
    setCurrentPage((prev) => Math.max(prev - 1, 1));
  };

  const goToPage = () => {
    const pageNumber = parseInt(inputPage, 10);
    if (!isNaN(pageNumber) && pageNumber >= 1 && pageNumber <= totalPages) {
      setCurrentPage(pageNumber);
      setInputPage('');
    } else {
      alert(`Please enter a valid page number between 1 and ${totalPages}.`);
    }
  };

  return (
    <FluentProvider theme={theme}>
    <div className={classes.container}>
      <div className={classes.cardsWrapper}>{currentCards}</div>

      <div className={classes.pagination}>
        <Button
          appearance="secondary"
          onClick={goToPreviousPage}
          disabled={currentPage === 1}
        >
          <ArrowLeft24Regular />
        </Button>
        <Button
          appearance="secondary"
          onClick={goToNextPage}
          disabled={currentPage === totalPages}
        >
          <ArrowRight24Regular />
        </Button>
        <TextField
          label="Go to page:"
          value={inputPage}
          onChange={(e) => setInputPage((e.target as HTMLInputElement).value)}
          styles={{ root: { width: '100px' } }}
        />
        <Button onClick={goToPage} appearance="primary">
          Go
        </Button>
        <Text>
          Page {currentPage} of {totalPages}
        </Text>
      </div>
    </div>
    </FluentProvider>
  );
};

export default CardContainer;
