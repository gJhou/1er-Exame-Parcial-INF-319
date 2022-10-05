library(datasets)
data(iris)
summary(iris)
#pairs(iris[,1:4],col=c("red","green","blue"))
#pairs(cbind(iris[,1:4], iris.mds$points), cex=0.6, gap=0,col=c("red", "green", "blue"), main="Iris")

pairs(iris[1:4],main="(ROJO=setosa,VERDE=versicolor,AZUL=virginica)",
      pch=21,  bg=c("red","green3","blue")[unclass(iris$Species)])
plot(iris)

