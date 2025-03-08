// apps\dashboard-client\src\components\Containers\Card.tsx
import {
  makeStyles,
  Body1,
  Caption1,
  Button,
} from "@fluentui/react-components";
import { ArrowReplyRegular, ShareRegular } from "@fluentui/react-icons";
import {
  Card,
  CardFooter,
  CardHeader,
  CardPreview,
} from "@fluentui/react-components";
import {
  Delete16Regular as IconDelete,
  Edit16Regular as IconEdit,
} from "@fluentui/react-icons/fonts";
import { useNavigate } from "react-router-dom";

const resolveAsset = (asset?: string) => {
  const ASSET_URL = "/";
  return `${ASSET_URL}${asset ?? "TopicDefaultIcon.svg"}`;
};

const useStyles = makeStyles({
  card: {
    margin: "auto",
    width: "320px",
    maxWidth: "400px",
    boxShadow: "0 1px 3px rgba(0,0,0,0.12), 0 1px 2px rgba(190,0,60,0.24)",
    transition: "all 0.3s cubic-bezier(.25,.8,.25,1)",
  },

  cardHover: {
    boxShadow: "0 14px 28px rgba(0,0,0,0.25), 0 10px 10px rgba(0,0,0,0.22)",
  },

  cardFocus: {
    outline: "none",
  },
  cardFooter: {
    display: "flex",
    justifyContent: "space-between",
    alignItems: "center",
    padding: "10px",
    borderTop: "1px solid #f0f0f0",
  },
  cardPreview: {
    padding: "10px",
    border: "1px solid #f0f0f0",
    borderRadius: "4px",
    overflow: "hidden",
  },
  cardFooterAction: {
    display: "flex",
    alignItems: "center",
    gap: "5px",
  },
  cardFooterActionButton: {
    padding: "5px",
    border: "1px solid #f0f0f0",
    borderRadius: "4px",
    cursor: "pointer",
    backgroundColor: "#f0f0f0",
  },
});

interface DashCardProps {
  modelName?: string;
  modelId?: string;
  name?: string;
  title?: string;
  description?: string;
  imgPath?: string;
  imgAlt?: string;
  content?: string;
}
export const DashCard: React.FC<DashCardProps> = ({
  modelName = "topics",
  modelId,
  name,
  title,
  description,
  imgPath = "TopicDefaultIcon.svg",
  imgAlt = "Image",
  content,
}) => {
  const styles = useStyles();
  const navigate = useNavigate();

  return (
    <Card
      className={`${styles.card} hover:${styles.cardHover} focus:${styles.cardFocus}`}
    >
      <CardHeader
        image={
          <img
            src={resolveAsset(imgPath)}
            alt={imgAlt}
            style={{ width: 24, height: 24, objectFit: "cover" }}
          />
        }
        header={
          <Body1>
            <strong>{title ?? name}</strong>
          </Body1>
        }
        action={
          <>
            <Button
              icon={<IconDelete style={{ color: "red" }} />}
              onClick={() => {
                navigate(`/${modelName}s/delete/${modelId}`);
              }}
            />
            <Button
              icon={<IconEdit style={{ color: "blue" }} />}
              onClick={() => {
                navigate(`/${modelName}s/edit/${modelId}`);
              }}
            />
          </>
        }
        description={<Caption1>{description ?? name}</Caption1>}
      />

      <CardPreview>
        <Body1
          style={{
            marginLeft: 10,
            marginRight: 10,
            whiteSpace: "pre-line",
            wordBreak: "break-word",
            overflowWrap: "break-word",
          }}
        >
          {content ?? description ?? name}
        </Body1>
      </CardPreview>

      <CardFooter>
        <Button
          icon={<ArrowReplyRegular fontSize={16} />}
          onClick={() => {
            alert("Reply");
          }}
        >
          Reply
        </Button>
        <Button
          icon={<ShareRegular fontSize={16} />}
          onClick={() => {
            alert("Share");
          }}
        >
          Share
        </Button>
      </CardFooter>
    </Card>
  );
};
