#!/bin/bash
[ $CATALINA_HOME ] || export CATALINA_HOME="/var/local/apache-tomcat"

$CATALINA_HOME/bin/shutdown.sh
timeout 3 tail -f $CATALINA_HOME/logs/catalina.out
echo Tomcat stopped.
sudo rm $CATALINA_HOME/webapps/aegean* -rf
echo Aegean undeployed.
./gradlew clean war
echo Aegean war rebuilt.
read -p "Press [Enter] to continue..."
sudo cp build/libs/aegean.war $CATALINA_HOME/webapps/
echo Aegean war redeployed.

sudo $CATALINA_HOME/bin/startup.sh
timeout 6 tail -f $CATALINA_HOME/logs/catalina.out

echo Tomcat started. 
tail -f /var/local/apache-tomcat/logs/catalina.out
