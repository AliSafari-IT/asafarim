// src/components/CardContainer.tsx
import React, { useState } from 'react';
import {
  FluentProvider,
  makeStyles,
  Text,
  webDarkTheme,
  webLightTheme,
} from '@fluentui/react-components';
import { DashCard } from './DashCard';
import { TextField } from '@fluentui/react';
import { useTheme } from '../../../hooks/useTheme';
import { ArrowLeft24Regular, ArrowRight24Regular } from '@fluentui/react-icons';
import dashboardCards from '../../../data/dashboardCards';

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
    gap: '5px',
  },
});

function MdSkipNext({ click }: { click: () => void }) {
  const l = "2.5em";
  return <svg
    xmlns="http://www.w3.org/2000/svg"
    style={{ cursor: 'pointer' }}
    onClick={click}
    stroke="currentColor" fill="currentColor" 
    strokeWidth={0} 
    viewBox="0 0 24 24" 
    height={l} width={l}>
    <path d="M6 18l8.5-6L6 6v12zM16 6v12h2V6h-2z" />
  </svg>;
}

const CardContainer: React.FC = () => {
  const classes = useStyles();
  const totalCards = dashboardCards.length; // Adjust as needed
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
        {totalPages > 1 && <div className={classes.pagination}>
          <ArrowLeft24Regular onClick={goToPreviousPage} style={{ cursor: 'pointer' }} />
          <ArrowRight24Regular onClick={goToNextPage} style={{ cursor: 'pointer' }} />
          <TextField
            value={inputPage}
            onChange={(e) => setInputPage((e.target as HTMLInputElement).value)}
            styles={{
              root: { width: '35px', margin: '10px', color: 'skyblue' },
              field: { textAlign: 'center', fontWeight: 'bold', verticalAlign: 'middle', color: 'blue' },
            }}
            onKeyUp={(e) => {
              if (e.key === 'Enter') {
                goToPage();
              }
            }}
          />
          <MdSkipNext click={goToPage} />
          <Text>
            Page {currentPage} of {totalPages}
          </Text>
        </div>}
      </div>
    </FluentProvider>
  );
};

export default CardContainer;
