import React from "react";
import clsx from "clsx";
import styles from "./styles.module.css";

type FeatureItem = {
  title: string;
  href: string;
  svg: JSX.Element;
  description: JSX.Element;
  bgColor: string;
  darkBgColor: string;
};

const FeatureList: FeatureItem[] = [
  {
    title: "Technical Insights",
    href: "https://asafarim.com/essential-insights/intro",
    svg: (
      <svg
        xmlns="http://www.w3.org/2000/svg"
        viewBox="0 0 512 512"
        className={styles.featureSvg}
      >
        <defs>
          <linearGradient
            id="techGradientLight"
            x1="0%"
            y1="0%"
            x2="100%"
            y2="100%"
          >
            <stop offset="0%" stopColor="#4F46E5" />
            <stop offset="100%" stopColor="#10B981" />
          </linearGradient>
          <linearGradient
            id="techGradientDark"
            x1="0%"
            y1="0%"
            x2="100%"
            y2="100%"
          >
            <stop offset="0%" stopColor="#6366F1" />
            <stop offset="100%" stopColor="#34D399" />
          </linearGradient>
          <filter id="techShadow" x="-20%" y="-20%" width="140%" height="140%">
            <feDropShadow
              dx="2"
              dy="2"
              stdDeviation="5"
              floodColor="rgba(0,0,0,0.3)"
            />
          </filter>
        </defs>

        {/* Base circle */}
        <circle
          cx="256"
          cy="256"
          r="220"
          fill="none"
          stroke="var(--feature-stroke-color)"
          strokeWidth="8"
          className={styles.featureBase}
        />

        {/* Code window frame */}
        <rect
          x="120"
          y="140"
          width="272"
          height="220"
          rx="12"
          fill="var(--feature-secondary-color)"
          className={styles.featureWindow}
        />
        <rect
          x="120"
          y="140"
          width="272"
          height="30"
          rx="12"
          fill="var(--feature-accent-color)"
          className={styles.featureWindowHeader}
        />

        {/* Window buttons */}
        <circle cx="135" cy="155" r="5" fill="#FF5F56" />
        <circle cx="155" cy="155" r="5" fill="#FFBD2E" />
        <circle cx="175" cy="155" r="5" fill="#27C93F" />

        {/* Code lines */}
        <rect
          x="140"
          y="190"
          width="100"
          height="10"
          rx="2"
          fill="var(--feature-code-color-1)"
          className={styles.featureCodeLine1}
        />
        <rect
          x="140"
          y="210"
          width="180"
          height="10"
          rx="2"
          fill="var(--feature-code-color-2)"
          className={styles.featureCodeLine2}
        />
        <rect
          x="160"
          y="230"
          width="150"
          height="10"
          rx="2"
          fill="var(--feature-code-color-3)"
          className={styles.featureCodeLine3}
        />
        <rect
          x="160"
          y="250"
          width="120"
          height="10"
          rx="2"
          fill="var(--feature-code-color-2)"
          className={styles.featureCodeLine4}
        />
        <rect
          x="140"
          y="270"
          width="200"
          height="10"
          rx="2"
          fill="var(--feature-code-color-1)"
          className={styles.featureCodeLine5}
        />
        <rect
          x="140"
          y="290"
          width="160"
          height="10"
          rx="2"
          fill="var(--feature-code-color-3)"
          className={styles.featureCodeLine6}
        />
        <rect
          x="160"
          y="310"
          width="180"
          height="10"
          rx="2"
          fill="var(--feature-code-color-2)"
          className={styles.featureCodeLine7}
        />

        {/* Floating gear */}
        <g className={styles.featureGear}>
          <path
            d="M380,200 L400,200 L405,220 L375,220 Z"
            fill="var(--feature-accent-color)"
          />
          <path
            d="M380,240 L400,240 L405,260 L375,260 Z"
            fill="var(--feature-accent-color)"
          />
          <path
            d="M360,220 L380,215 L380,245 L360,240 Z"
            fill="var(--feature-accent-color)"
          />
          <path
            d="M400,215 L420,220 L420,240 L400,245 Z"
            fill="var(--feature-accent-color)"
          />
          <circle
            cx="390"
            cy="230"
            r="15"
            fill="var(--feature-primary-color)"
          />
        </g>

        {/* Floating brackets */}
        <g className={styles.featureBracket1}>
          <path
            d="M100,180 C90,200 90,250 100,270"
            fill="none"
            stroke="var(--feature-primary-color)"
            strokeWidth="6"
            strokeLinecap="round"
          />
        </g>
        <g className={styles.featureBracket2}>
          <path
            d="M412,180 C422,200 422,250 412,270"
            fill="none"
            stroke="var(--feature-primary-color)"
            strokeWidth="6"
            strokeLinecap="round"
          />
        </g>
      </svg>
    ),
    description: (
      <>
        Explore in-depth technical articles and tutorials on software
        development, architecture, and best practices that will elevate your
        coding skills.
      </>
    ),
    bgColor: "rgba(79, 70, 229, 0.1)",
    darkBgColor: "rgba(99, 102, 241, 0.2)",
  },
  {
    title: "Project Updates",
    href: "https://asafarim.com/projects",
    svg: (
      <svg
        xmlns="http://www.w3.org/2000/svg"
        viewBox="0 0 512 512"
        className={styles.featureSvg}
      >
        <defs>
          <linearGradient
            id="projectGradientLight"
            x1="0%"
            y1="0%"
            x2="100%"
            y2="100%"
          >
            <stop offset="0%" stopColor="#EC4899" />
            <stop offset="100%" stopColor="#8B5CF6" />
          </linearGradient>
          <linearGradient
            id="projectGradientDark"
            x1="0%"
            y1="0%"
            x2="100%"
            y2="100%"
          >
            <stop offset="0%" stopColor="#F472B6" />
            <stop offset="100%" stopColor="#A78BFA" />
          </linearGradient>
          <filter
            id="projectShadow"
            x="-20%"
            y="-20%"
            width="140%"
            height="140%"
          >
            <feDropShadow
              dx="2"
              dy="2"
              stdDeviation="5"
              floodColor="rgba(0,0,0,0.3)"
            />
          </filter>
        </defs>

        {/* Base circle */}
        <circle
          cx="256"
          cy="256"
          r="220"
          fill="none"
          stroke="var(--feature-stroke-color)"
          strokeWidth="8"
          className={styles.featureBase}
        />

        {/* Dashboard board */}
        <rect
          x="120"
          y="140"
          width="272"
          height="220"
          rx="12"
          fill="var(--feature-secondary-color)"
          className={styles.featureBoard}
        />
        <rect
          x="120"
          y="140"
          width="272"
          height="30"
          rx="12"
          fill="var(--feature-accent-color)"
          className={styles.featureBoardHeader}
        />

        {/* Chart elements */}
        <rect
          x="140"
          y="190"
          width="40"
          height="150"
          rx="4"
          fill="var(--feature-chart-color-1)"
          className={styles.featureBar1}
        />
        <rect
          x="190"
          y="220"
          width="40"
          height="120"
          rx="4"
          fill="var(--feature-chart-color-2)"
          className={styles.featureBar2}
        />
        <rect
          x="240"
          y="160"
          width="40"
          height="180"
          rx="4"
          fill="var(--feature-chart-color-3)"
          className={styles.featureBar3}
        />
        <rect
          x="290"
          y="200"
          width="40"
          height="140"
          rx="4"
          fill="var(--feature-chart-color-4)"
          className={styles.featureBar4}
        />

        {/* Trend line */}
        <path
          d="M140,320 C180,280 220,300 260,260 C300,220 340,240 380,200"
          fill="none"
          stroke="var(--feature-primary-color)"
          strokeWidth="4"
          strokeLinecap="round"
          className={styles.featureTrendLine}
        />

        {/* Floating data points */}
        <circle
          cx="140"
          cy="320"
          r="8"
          fill="var(--feature-primary-color)"
          className={styles.featureDataPoint1}
        />
        <circle
          cx="190"
          cy="290"
          r="8"
          fill="var(--feature-primary-color)"
          className={styles.featureDataPoint2}
        />
        <circle
          cx="240"
          cy="260"
          r="8"
          fill="var(--feature-primary-color)"
          className={styles.featureDataPoint3}
        />
        <circle
          cx="290"
          cy="230"
          r="8"
          fill="var(--feature-primary-color)"
          className={styles.featureDataPoint4}
        />
        <circle
          cx="340"
          cy="210"
          r="8"
          fill="var(--feature-primary-color)"
          className={styles.featureDataPoint5}
        />

        {/* Floating notification */}
        <g className={styles.featureNotification}>
          <rect
            x="350"
            y="150"
            width="50"
            height="50"
            rx="25"
            fill="var(--feature-accent-color)"
          />
          <text
            x="375"
            y="180"
            textAnchor="middle"
            fill="white"
            fontSize="24"
            fontWeight="bold"
          >
            +
          </text>
        </g>
      </svg>
    ),
    description: (
      <>
        Stay up-to-date with the latest developments, features, and improvements
        in the ASafariM project with regular release notes and roadmap updates. 
      </>
    ),
    bgColor: "rgba(236, 72, 153, 0.1)",
    darkBgColor: "rgba(244, 114, 182, 0.2)",
  },
  {
    title: "Community Contributions",
    href: "https://asafarim.com/community",
    svg: (
      <svg
        xmlns="http://www.w3.org/2000/svg"
        viewBox="0 0 512 512"
        className={styles.featureSvg}
      >
        <defs>
          <linearGradient
            id="communityGradientLight"
            x1="0%"
            y1="0%"
            x2="100%"
            y2="100%"
          >
            <stop offset="0%" stopColor="#F59E0B" />
            <stop offset="100%" stopColor="#EF4444" />
          </linearGradient>
          <linearGradient
            id="communityGradientDark"
            x1="0%"
            y1="0%"
            x2="100%"
            y2="100%"
          >
            <stop offset="0%" stopColor="#FBBF24" />
            <stop offset="100%" stopColor="#F87171" />
          </linearGradient>
          <filter
            id="communityShadow"
            x="-20%"
            y="-20%"
            width="140%"
            height="140%"
          >
            <feDropShadow
              dx="2"
              dy="2"
              stdDeviation="5"
              floodColor="rgba(0,0,0,0.3)"
            />
          </filter>
        </defs>

        {/* Base circle */}
        <circle
          cx="256"
          cy="256"
          r="220"
          fill="none"
          stroke="var(--feature-stroke-color)"
          strokeWidth="8"
          className={styles.featureBase}
        />

        {/* Central hub */}
        <circle
          cx="256"
          cy="256"
          r="60"
          fill="var(--feature-secondary-color)"
          className={styles.featureHub}
        />
        <circle
          cx="256"
          cy="256"
          r="40"
          fill="var(--feature-accent-color)"
          className={styles.featureHubInner}
        />

        {/* Connection lines */}
        <path
          d="M256,196 L256,130"
          stroke="var(--feature-connection-color)"
          strokeWidth="4"
          strokeDasharray="5,5"
          className={styles.featureConnection1}
        />
        <path
          d="M256,316 L256,380"
          stroke="var(--feature-connection-color)"
          strokeWidth="4"
          strokeDasharray="5,5"
          className={styles.featureConnection2}
        />
        <path
          d="M196,256 L130,256"
          stroke="var(--feature-connection-color)"
          strokeWidth="4"
          strokeDasharray="5,5"
          className={styles.featureConnection3}
        />
        <path
          d="M316,256 L380,256"
          stroke="var(--feature-connection-color)"
          strokeWidth="4"
          strokeDasharray="5,5"
          className={styles.featureConnection4}
        />
        <path
          d="M215,215 L160,160"
          stroke="var(--feature-connection-color)"
          strokeWidth="4"
          strokeDasharray="5,5"
          className={styles.featureConnection5}
        />
        <path
          d="M297,215 L352,160"
          stroke="var(--feature-connection-color)"
          strokeWidth="4"
          strokeDasharray="5,5"
          className={styles.featureConnection6}
        />
        <path
          d="M215,297 L160,352"
          stroke="var(--feature-connection-color)"
          strokeWidth="4"
          strokeDasharray="5,5"
          className={styles.featureConnection7}
        />
        <path
          d="M297,297 L352,352"
          stroke="var(--feature-connection-color)"
          strokeWidth="4"
          strokeDasharray="5,5"
          className={styles.featureConnection8}
        />

        {/* Community nodes */}
        <g className={styles.featurePerson1}>
          <circle cx="130" cy="256" r="25" fill="var(--feature-node-color-1)" />
          <path
            d="M130,246 C133,246 136,249 136,252 C136,255 133,258 130,258 C127,258 124,255 124,252 C124,249 127,246 130,246 Z"
            fill="var(--feature-secondary-color)"
          />
          <path
            d="M130,260 C136,260 142,264 142,270 L142,275 L118,275 L118,270 C118,264 124,260 130,260 Z"
            fill="var(--feature-secondary-color)"
          />
        </g>

        <g className={styles.featurePerson2}>
          <circle cx="256" cy="130" r="25" fill="var(--feature-node-color-2)" />
          <path
            d="M256,120 C259,120 262,123 262,126 C262,129 259,132 256,132 C253,132 250,129 250,126 C250,123 253,120 256,120 Z"
            fill="var(--feature-secondary-color)"
          />
          <path
            d="M256,134 C262,134 268,138 268,144 L268,149 L244,149 L244,144 C244,138 250,134 256,134 Z"
            fill="var(--feature-secondary-color)"
          />
        </g>

        <g className={styles.featurePerson3}>
          <circle cx="380" cy="256" r="25" fill="var(--feature-node-color-3)" />
          <path
            d="M380,246 C383,246 386,249 386,252 C386,255 383,258 380,258 C377,258 374,255 374,252 C374,249 377,246 380,246 Z"
            fill="var(--feature-secondary-color)"
          />
          <path
            d="M380,260 C386,260 392,264 392,270 L392,275 L368,275 L368,270 C368,264 374,260 380,260 Z"
            fill="var(--feature-secondary-color)"
          />
        </g>

        <g className={styles.featurePerson4}>
          <circle cx="256" cy="380" r="25" fill="var(--feature-node-color-4)" />
          <path
            d="M256,370 C259,370 262,373 262,376 C262,379 259,382 256,382 C253,382 250,379 250,376 C250,373 253,370 256,370 Z"
            fill="var(--feature-secondary-color)"
          />
          <path
            d="M256,384 C262,384 268,388 268,394 L268,399 L244,399 L244,394 C244,388 250,384 256,384 Z"
            fill="var(--feature-secondary-color)"
          />
        </g>

        <g className={styles.featurePerson5}>
          <circle cx="160" cy="160" r="25" fill="var(--feature-node-color-5)" />
          <path
            d="M160,150 C163,150 166,153 166,156 C166,159 163,162 160,162 C157,162 154,159 154,156 C154,153 157,150 160,150 Z"
            fill="var(--feature-secondary-color)"
          />
          <path
            d="M160,164 C166,164 172,168 172,174 L172,179 L148,179 L148,174 C148,168 154,164 160,164 Z"
            fill="var(--feature-secondary-color)"
          />
        </g>

        <g className={styles.featurePerson6}>
          <circle cx="352" cy="160" r="25" fill="var(--feature-node-color-1)" />
          <path
            d="M352,150 C355,150 358,153 358,156 C358,159 355,162 352,162 C349,162 346,159 346,156 C346,153 349,150 352,150 Z"
            fill="var(--feature-secondary-color)"
          />
          <path
            d="M352,164 C358,164 364,168 364,174 L364,179 L340,179 L340,174 C340,168 346,164 352,164 Z"
            fill="var(--feature-secondary-color)"
          />
        </g>

        {/* Floating plus signs */}
        <g className={styles.featurePlus1}>
          <circle cx="160" cy="352" r="20" fill="var(--feature-accent-color)" />
          <path
            d="M160,342 L160,362"
            stroke="var(--feature-secondary-color)"
            strokeWidth="4"
            strokeLinecap="round"
          />
          <path
            d="M150,352 L170,352"
            stroke="var(--feature-secondary-color)"
            strokeWidth="4"
            strokeLinecap="round"
          />
        </g>

        <g className={styles.featurePlus2}>
          <circle cx="352" cy="352" r="20" fill="var(--feature-accent-color)" />
          <path
            d="M352,342 L352,362"
            stroke="var(--feature-secondary-color)"
            strokeWidth="4"
            strokeLinecap="round"
          />
          <path
            d="M342,352 L362,352"
            stroke="var(--feature-secondary-color)"
            strokeWidth="4"
            strokeLinecap="round"
          />
        </g>
      </svg>
    ),
    description: (
      <>
        Learn about how you can contribute to the ASafariM project and become
        part of our growing community of developers and enthusiasts.
      </>
    ),
    bgColor: "rgba(245, 158, 11, 0.1)",
    darkBgColor: "rgba(251, 191, 36, 0.2)",
  },
];

function Feature({
  title,
  href,
  svg,
  description,
  bgColor,
  darkBgColor,
}: FeatureItem) {
  return (
    <div className={clsx("col col--4")}>
      <div
        className={styles.featureCard}
        style={{
          backgroundColor: "var(--ifm-background-surface-color)",
          boxShadow: "var(--feature-card-shadow)",
        }}
      >
        <div className={styles.featureIconContainer}>{svg}</div>
        <div className={styles.featureContent}>
          <h3 className={styles.featureTitle}>{title}</h3>
          <a href={href} className={styles.featureLink}>
            <p className={styles.featureDescription}>{description}</p>
          </a>
        </div>
      </div>
    </div>
  );
}

export default function HomepageFeatures(): JSX.Element {
  return (
    <section className={styles.features}>
      <div className="container">
        <div className={styles.featuresHeader}>
          <h2 className={styles.featuresTitle}>
            ASafariM Ecosystem
          </h2>
        </div>
        <div className="row">
          {FeatureList.map((props, idx) => (
            <Feature key={idx} {...props} />
          ))}
        </div>
      </div>
    </section>
  );
}
