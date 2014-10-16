package com.buraksay.aegean.application;

import java.util.HashSet;
import java.util.Set;

import javax.ws.rs.core.Application;

import com.buraksay.aegean.controller.IAmAliveController;

public class AegeanApplication extends Application {
    private final Set<Object> singletons = new HashSet<Object>();
    private final Set<Class<?>> empty = new HashSet<Class<?>>();

    public AegeanApplication() {

        singletons.add(new IAmAliveController());
    }

    /**
     * Get list of all controller.
     * 
     * @return
     */
    public Set<Object> getControllers() {
        return singletons;
    }

    @Override
    public Set<Class<?>> getClasses() {
        return empty;
    }

    @Override
    public Set<Object> getSingletons() {
        return singletons;
    }
}