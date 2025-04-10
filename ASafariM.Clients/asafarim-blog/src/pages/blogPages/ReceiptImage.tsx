import React, { useState, useEffect, useRef } from "react";

interface ImageDimensions {
  width: number;
  height: number;
}

const ReceiptImage: React.FC = () => {
  const [showMagnifier, setShowMagnifier] = useState<boolean>(false);
  const [imgDimensions, setImgDimensions] = useState<ImageDimensions>({ width: 0, height: 0 });
  const [cursorPosition, setCursorPosition] = useState<{ x: number, y: number }>({ x: 0, y: 0 });
  const imgRef = useRef<HTMLImageElement>(null);
  
  // Calculate zoom level
  const magnifierSize = 120;
  const zoomLevel = 3;
  
  // Load image dimensions on mount and when image loads
  useEffect(() => {
    const img = imgRef.current;
    if (img && img.complete && img.naturalWidth > 0) {
      setImgDimensions({
        width: img.naturalWidth,
        height: img.naturalHeight
      });
    }
  }, []);
  
  const handleImageLoad = (e: React.SyntheticEvent<HTMLImageElement>) => {
    const img = e.currentTarget;
    setImgDimensions({
      width: img.naturalWidth,
      height: img.naturalHeight
    });
  };
  
  // Handle mouse movements
  const handleMouseMove = (e: React.MouseEvent<HTMLDivElement>) => {
    const elem = e.currentTarget;
    const { top, left } = elem.getBoundingClientRect();
    
    // Calculate cursor position relative to the image
    const x = e.clientX - left;
    const y = e.clientY - top;
    
    setCursorPosition({ x, y });
  };
  
  // Ensure we have image dimensions for the magnifier
  const { width: imgWidth, height: imgHeight } = imgDimensions;
  const { x, y } = cursorPosition;
  
  return (
    <div className="img-wrapper">
      <div 
        className="img-container"
        style={{ position: 'relative' }}
        onMouseEnter={() => setShowMagnifier(true)}
        onMouseLeave={() => setShowMagnifier(false)}
        onMouseMove={handleMouseMove}
      >
        <img 
          ref={imgRef}
          src="/img/blog/codeium-pro-ultimate.png" 
          alt="Codeium Pro Ultimate Subscription Receipt" 
          className="receipt-image"
          onLoad={handleImageLoad}
        />
        
        {showMagnifier && imgWidth > 0 && imgHeight > 0 && (
          <div
            style={{
              position: 'absolute',
              // Position the magnifier
              left: `${x}px`,
              top: `${y}px`,
              // Size of the magnifier
              width: `${magnifierSize}px`,
              height: `${magnifierSize}px`,
              // Move it center to cursor
              transform: 'translate(-50%, -50%)',
              border: '2px solid white',
              borderRadius: '50%',
              // Background settings
              backgroundImage: `url(/img/blog/codeium-pro-ultimate.png)`,
              backgroundRepeat: 'no-repeat',
              // Calculate the background position
              backgroundSize: `${imgWidth * zoomLevel}px ${imgHeight * zoomLevel}px`,
              backgroundPosition: `
                ${-x * zoomLevel + magnifierSize / 2}px 
                ${-y * zoomLevel + magnifierSize / 2}px
              `,
              pointerEvents: 'none',
              opacity: 1,
              backgroundColor: 'white',
              boxShadow: '0 5px 10px rgba(0,0,0,0.3)',
              zIndex: 1000
            }}
          />
        )}
      </div>
      <div className="img-caption">
        <strong>Note:</strong> The receipt image is a personal record of the Codeium Pro Ultimate subscription purchase, included for documentation purposes.
      </div>
    </div>
  );
};

export default ReceiptImage;