import React from "react";
import classnames from "clsx";
import Zoom from "react-medium-image-zoom";
import "react-medium-image-zoom/dist/styles.css";

interface FigureProps {
  src: string;
  caption: string;
  className?: string;
}

function Figure({ src, caption, className }: FigureProps) {
  let figureClasses = classnames("figure", className);
  return (
    <figure className={figureClasses}>
      <Zoom>
        <img src={src} alt={caption} />
      </Zoom>
      <figcaption className="text-center text-gray-600">{caption}</figcaption>
    </figure>
  );
}

export default Figure;
