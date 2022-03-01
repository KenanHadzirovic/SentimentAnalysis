setwd("C:/Users/Kenan/Desktop/master")

pos_tokens <- readLines("lexicon/positive-words-BS.txt", warn=FALSE)
neg_tokens <- readLines("lexicon/negative-words-BS.txt", warn=FALSE)

tokenize <- function(text) {
  text <- tolower(text)
  text <- gsub(". ", " ", text, fixed = TRUE)
  text <- gsub(": ", " ", text, fixed = TRUE)
  text <- gsub("? ", " ", text, fixed = TRUE)
  text <- gsub("! ", " ", text, fixed = TRUE)
  text <- gsub("; ", " ", text, fixed = TRUE)
  text <- gsub(", ", " ", text, fixed = TRUE)
  text <- gsub("\`", " ", text, fixed = TRUE)
  text <- gsub("\n", " ", text, fixed = TRUE)
  text <- unlist(strsplit(text, " "))
  text[nchar(text) > 3]
}

realDocs <- readLines("relatedArticles.csv", warn=FALSE)

calc_Probs <- function(tokens) {
  counts <- table(tokens) + 1
  log(counts/sum(counts))
}

pos_probs <- calc_Probs(pos_tokens)
neg_probs <- calc_Probs(neg_tokens)

calc_Prob_Rare <- function(tokens) {
  counts <- table(tokens) + 1
  log(1/sum(counts))
}

pos_probs_rare <- calc_Prob_Rare(pos_tokens)
neg_probs_rare <- calc_Prob_Rare(neg_tokens)

calc_Sentiment <- function(review) {
  test <- tokenize(review)
  pos_pred <- exp(sum(pos_probs[test], na.rm = TRUE))
  neg_pred <- exp(sum(neg_probs[test], na.rm = TRUE))
  ifelse(pos_pred > neg_pred, "positive", "negative")
}

tapply(realDocs, 1:length(realDocs), calc_Sentiment)