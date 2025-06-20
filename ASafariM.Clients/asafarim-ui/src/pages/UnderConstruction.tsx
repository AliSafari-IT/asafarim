import React, { useState, useEffect } from "react";
import {
  FluentProvider,
  webLightTheme,
  webDarkTheme,
  Button,
  Title1,
  Subtitle1,
  Body1,
  Caption1,
} from "@fluentui/react-components";
import {
  Toolbox24Regular,
  Warning24Regular,
  Building24Regular,
  ArrowLeft24Regular,
  Lightbulb24Regular,
  Rocket24Regular,
  Clock24Regular,
} from "@fluentui/react-icons";
import { useNavigate } from "react-router-dom";
import { useTheme } from "@/contexts/ThemeContext";
import "./UnderConstruction.css";

interface UnderConstructionProps {
  title: string;
  constructionTips: string[];
  description: string;
  bodyText: string;
}

const UnderConstruction: React.FC<UnderConstructionProps> = ({
  title,
  constructionTips,
  description,
  bodyText,
}) => {
  const { theme } = useTheme();
  const currentTheme = theme === "dark" ? webDarkTheme : webLightTheme;
  const navigate = useNavigate();
  const [progress, setProgress] = useState(0);
  const [showToolTip, setShowToolTip] = useState(false);
  const [tipIndex, setTipIndex] = useState(0);

  // Simulate construction progress
  useEffect(() => {
    const timer = setInterval(() => {
      setProgress((prevProgress) => {
        const newProgress = prevProgress + 0.1;
        return newProgress > 100 ? 0 : newProgress;
      });
    }, 100);

    return () => clearInterval(timer);
  }, []);

  // Rotate through tips
  useEffect(() => {
    const tipTimer = setInterval(() => {
      setTipIndex((prevIndex) => (prevIndex + 1) % constructionTips.length);
    }, 5000);

    return () => clearInterval(tipTimer);
  }, [constructionTips.length]);

  // Toggle tooltip
  const handleToolTipToggle = () => {
    setShowToolTip((prev) => !prev);
  };

  // Navigate back to dashboard
  const goBack = () => {
    navigate("/dashboard");
  };

  return (
    <FluentProvider theme={currentTheme}>
      <div className="under-construction-container">
        <div className="construction-content">
          <div className="construction-header">
            <Button
              icon={<ArrowLeft24Regular />}
              appearance="subtle"
              onClick={goBack}
              className="back-button"
            >
              Goto to Dashboard
            </Button>
          </div>

          <div className="construction-main">
            <div className="construction-icons">
              <div className="icon-container hammer">
                <Toolbox24Regular />
              </div>
              <div className="icon-container wrench">
                <Building24Regular />
              </div>
              <div className="icon-container cone">
                <Warning24Regular />
              </div>
            </div>

            <Title1 className="construction-title">{title}</Title1>

            <div className="construction-animation">
              <div className="construction-scene">
                <div className="building">
                  <div className="floor floor-1"></div>
                  <div className="floor floor-2"></div>
                  <div className="floor floor-3"></div>
                  <div className="crane">
                    <div className="crane-arm"></div>
                    <div className="crane-weight"></div>
                    <div className="crane-cabin"></div>
                    <div className="crane-cable"></div>
                  </div>
                </div>
                <div className="clouds">
                  <div className="cloud cloud-1"></div>
                  <div className="cloud cloud-2"></div>
                  <div className="cloud cloud-3"></div>
                </div>
              </div>
            </div>

            <Subtitle1 className="construction-subtitle">
              {description}
            </Subtitle1>

            <Body1 className="construction-description">{bodyText}</Body1>

            <div className="progress-container">
              <div className="progress-label">
                <Clock24Regular />
                <span>Construction Progress</span>
              </div>
              <div className="progress-bar">
                <div
                  className="progress-fill"
                  style={{ width: `${progress}%` }}
                ></div>
              </div>
              <Caption1>{Math.floor(progress)}% Complete</Caption1>
            </div>

            <div className="construction-tip-container">
              <div className="tip-header">
                <Lightbulb24Regular className="tip-icon" />
                <span>Did you know?</span>
              </div>
              <div className="tip-content">
                <p className="tip-text">{constructionTips[tipIndex]}</p>
                <div className="tip-indicators">
                  {constructionTips.map((_, index) => (
                    <div
                      key={index}
                      className={`tip-indicator ${
                        index === tipIndex ? "active" : ""
                      }`}
                    ></div>
                  ))}
                </div>
              </div>
            </div>

            <div className="construction-actions">
              <Button
                icon={<Rocket24Regular />}
                appearance="primary"
                onClick={handleToolTipToggle}
                className="notify-button"
              >
                Get Notified When Ready
              </Button>
            </div>

            {showToolTip && (
              <div className="tooltip-popup">
                <p>
                  Thanks for your interest! This feature is also under
                  construction. 😊
                </p>
                <Button appearance="subtle" onClick={handleToolTipToggle}>
                  Close
                </Button>
              </div>
            )}
          </div>

          <div className="construction-footer">
            <Caption1> ASafariM - Estimated completion: Coming Soon</Caption1>
          </div>
        </div>
      </div>
    </FluentProvider>
  );
};

export default UnderConstruction;
