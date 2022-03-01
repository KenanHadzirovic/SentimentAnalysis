library(SentimentAnalysis, warn=FALSE)
args <- commandArgs(trailingOnly = TRUE)

setwd("C:/Users/Kenan/Desktop/master")

negativeWords <- readLines("lexicon/negative-words-BS.txt", warn=FALSE)
positiveWords <- readLines("lexicon/positive-words-BS.txt", warn=FALSE)

dictionaryBosnian <- SentimentDictionaryBinary(negativeWords, positiveWords)
realDocs <- readLines("relatedArticles.csv", warn=FALSE)

sentiment <- analyzeSentiment(realDocs,
                              language="en",
                              rules=list("BosnianSentiment"=list(ruleSentiment, dictionaryBosnian)))

returnValue <- convertToBinaryResponse(sentiment$BosnianSentiment)

returnValue