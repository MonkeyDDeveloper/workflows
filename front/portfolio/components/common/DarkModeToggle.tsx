"use client";
import React from "react";
import { useTheme } from "next-themes";
import Switch from "./Switch";
import { useState } from "react";

const DarkModeToggle = () => {
    const { theme, setTheme, resolvedTheme } = useTheme();
    const [isChecked, setIsChecked] = useState(resolvedTheme == "dark");

    function handleChange(checked: boolean) {
        setTheme(checked ? "dark" : "light");
        setIsChecked(checked);
    }

    return (
        <Switch isChecked={isChecked} onToggle={handleChange} />
    );
};

export default DarkModeToggle;